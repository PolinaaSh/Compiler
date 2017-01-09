using System;
using System.Collections.Generic;
using Antlr.Runtime.Tree;

using TokenSs = Antlr.Runtime.CommonToken;

namespace MathLang
{
    public class ParseTreeSk
    {
        public ParseTreeSk()
        {
            /* Сделано
             * b[b[1]] = b[1];
             * if(3.0 > 2) в одном случае float to int может не отработаь
             * ват! bool asds = true; if(asds > (10 == 0))
             * есть проблема { A = b; int b; A = A + b; } 
             * добавить индексацию в IdentDescription для переменных.
             * каждая нода будет хранить IdentDescription IdentDescription 
             * если он есть то это переменная и с ней можно работаь
             * т.е. в любой момент мы можем получить доступ к индефекатору и по номеру.
             */
        }
        public Scope Run(NodeData program)
        {
            Scope globalScope = new Scope(TypeScope.Global);

            SimpleTree(program, globalScope);
            FillVars(program, globalScope);

            return globalScope;
        }
        private void SimpleTree(NodeData node, Scope scope)
        {
            if (node == null)
                return;

            switch (node.Type)
            {
                case MathLangLexer.VAR:
                    List<NodeData> listSplitedVar = new List<NodeData>();
                    if (!node.check)
                    {
                        for (int i = 0; i < node.ChildCount; i++)
                        {
                            string typeVar = node.GetChild(i).Text;
                            for (int k = 0; k < node.GetChild(i).ChildCount; k++)
                            {
                                NodeData splitedNode = null;
                                if (node.GetChild(i).GetChild(k).Text != "array")
                                {
                                    node.GetChild(i).GetChild(k).Cast().TypeData = StrToDataType(typeVar);
                                    splitedNode = new NodeData(new TokenSs(MathLangLexer.VAR, "var"));
                                    NodeData type = new NodeData(new TokenSs(MathLangLexer.INT, String.Format("{0}", typeVar)));
                                    splitedNode.AddChild(type);
                                    splitedNode.AddChild(node.GetChild(i).GetChild(k));
                                    listSplitedVar.Add(splitedNode);
                                    splitedNode.check = true;
                                }
                                else
                                {
                                    listSplitedVar.AddRange(ArrayDescription(scope, node.GetChild(i).Cast()));
                                }
                            }
                        }
                        // запихнуть маркеры

                        NodeData tree = new NodeData();
                        foreach (NodeData n in listSplitedVar)
                            tree.AddChild(n);
                        node.Parent.ReplaceChildren(node.ChildIndex, node.ChildIndex, tree);
                    }

                    break;
                case MathLangLexer.NUMBER:
                    bool isFloat = node.Text.Contains(".");
                    node.TypeData = isFloat ? DataType.Real : DataType.Integer;
                    return;
                case MathLangLexer.TRUE:
                case MathLangLexer.FALSE:
                    node.TypeData = DataType.Boolean;
                    return;
                case MathLangLexer.CONST_:
                    List<NodeData> listVar = new List<NodeData>();
                    if (!node.check)
                    {
                        for (int i = 0; i < node.ChildCount; i++)
                        {
                            string typeVar = ParseConstType(node.GetChild(i).Text);

                            NodeData splitedNode = new NodeData(new TokenSs(MathLangLexer.CONST_, "const"));
                            NodeData type = new NodeData(new TokenSs(MathLangLexer.INT, String.Format("{0}", typeVar)));
                            splitedNode.AddChild(type);
                            splitedNode.AddChild(node.GetChild(i));
                            listVar.Add(splitedNode);
                            splitedNode.check = true;
                        }
                        // запихнуть маркеры

                        NodeData tree = new NodeData();
                        foreach (NodeData n in listVar)
                            tree.AddChild(n);
                        node.Parent.ReplaceChildren(node.ChildIndex, node.ChildIndex, tree);
                    }
                    return;
            }

            for (int i = 0; i < node.ChildCount; i++)
                SimpleTree(node.GetChild(i).Cast(), scope);
        }
        private void FillVars(NodeData node, Scope scope)
        {
            if (node == null)
                return;

            switch (node.Type)
            {
                case MathLangLexer.SCOPEBLOCK:
                    {
                        Scope newScope = new Scope(TypeScope.Non, scope);
                        for (int i = 0; i < node.ChildCount; i++)
                            FillVars(node.GetChild(i).Cast(), newScope);
                    }
                    return;
                case MathLangLexer.FUNC:
                    #region FUNC
                    {
                        Scope newScope = RegistrationFun(scope, node, node.GetChild(1).Cast());
                        AddScopeInNode(scope,node.GetChild(1).Cast());
                        for (int i = 2; i < node.ChildCount; i++)
                            FillVars(node.GetChild(i).Cast(), newScope);
                    }
                    #endregion
                    return;
                case MathLangLexer.PROC:
                    #region proc
                    Scope newSc = RegistrationFun(scope, node, node.GetChild(0).Cast());
                    AddScopeInNode(scope, node.GetChild(0).Cast());
                    for (int i = 1; i < node.ChildCount; i++)
                        FillVars(node.GetChild(i).Cast(), newSc);
                    #endregion
                    return;

                case MathLangLexer.IDENT:
                    #region ident
                    // Все переменные должны ссылаться на зону видимости
                    if (node.Text == "result" && scope.Function != null)
                    {
                        node.TypeData = scope.Function.TypeData;
                        NodeData splitedNode = new NodeData(new TokenSs(MathLangLexer.UNKNOWN, "Local"));
                        node.AddChild(splitedNode);
                    }
                    else if (node.ChildCount > 0 && node.GetChild(0).Text == "INDEX")
                    {
                        node.IdentDescription = AddScopeInNode(scope, node);
                        FillVars(node.GetChild(0).GetChild(0).Cast(), scope);
                    }
                    else
                    {
                        if (node.Parent.Text == ":=" && node.Parent.ChildCount == 4 && node.ChildIndex==2)
                            return;
                        node.IdentDescription = AddScopeInNode(scope, node);
                    }
                    #endregion
                    return;
                case MathLangLexer.VAR:
                    #region var
                    {
                        // Зарегать объявленные переменные
                        if (node.Parent.Text != "PARAMS")
                        {
                            ITree nodeVarIdent;
                            if (node.GetChild(1).Text.ToLower() != "array")
                            {
                                nodeVarIdent = node.GetChild(1);
                                IdentType it = node.Parent.Text.Equals("PROGRAM") ? IdentType.Global : IdentType.Local;
                                RegistrationVar(scope, node.Cast(), nodeVarIdent.Cast(), it, node.GetChild(0).Text);
                                AddScopeInNode(scope, node.GetChild(1).Cast());
                            }
                            else
                            {
                                nodeVarIdent = node.GetChild(2);
                                // IdentType it = node.Parent.Text.Equals("PROGRAM") ? IdentType.Global : (node.Parent.Text.Equals("PARAMS") ?IdentType.Param:IdentType.Local);
                                IdentType it = node.Parent.Text.Equals("PROGRAM") ? IdentType.Global : IdentType.Local;
                                RegistrationVar(scope, node.Cast(), nodeVarIdent.Cast(), it, node.GetChild(0).Text);
                                AddScopeInNode(scope, node.GetChild(2).Cast());
                            }
                         }
                    }
                    #endregion
                   return;

                case MathLangLexer.CONST_:
                #region const_
                    ITree nodeVarId;
                                nodeVarId = node.GetChild(1);
                                IdentType idt = node.Parent.Text.Equals("PROGRAM") ? IdentType.Global : IdentType.Local;
                                RegistrationVar(scope, node.Cast(), nodeVarId.Cast(), idt, node.GetChild(0).Text);
                                AddScopeInNode(scope, node.GetChild(1).Cast());
                #endregion
                   return;
                case MathLangLexer.PARAMS:
                    // Зарегать парметры функции и добавить зону видимости
                    #region params
                    for (int i = 0; i < node.ChildCount; i++)
                    {
                        string dataType = node.GetChild(i).Text;
                        if (dataType == "var")
                        {
                            dataType = node.GetChild(i).GetChild(0).Text;
                             RegistrationVar(scope, node.GetChild(i).Cast(), node.GetChild(i).GetChild(1).Cast(), IdentType.Param, dataType);
                             AddScopeInNode(scope, node.GetChild(i).GetChild(1).Cast());
                        }
                        else
                        {
                            for (int k = 0; k < node.GetChild(i).ChildCount; k++)
                            {
                                    RegistrationVar(scope, node.GetChild(i).Cast(), node.GetChild(i).GetChild(k).Cast(), IdentType.Param, dataType);
                                    AddScopeInNode(scope, node.GetChild(i).GetChild(k).Cast());
                            }
                        }
                    }

                    #endregion
                    return;
                case MathLangLexer.CALL:
                    #region CALL
                    IdentDescription ident = AddScopeInNode(scope, node.GetChild(0).Cast());
                    if (ident.TypeIdent == IdentType.Function)
                        CallFunc(node, ident, scope);
                    else if (ident.TypeIdent == IdentType.Procedure)
                        CallProc(node, ident, scope);
                    #endregion
                    return;

                case MathLangLexer.ADD:
                case MathLangLexer.SUB:
                case MathLangLexer.MUL:
                case MathLangLexer.DIVIDE:
                case MathLangLexer.MOD:
                case MathLangLexer.DIV:
                    #region mathOperation
                    {
                        // Проверяю используемые переменные и определяю их тип.
                        for (int i = 0; i < node.ChildCount; i++)
                            FillVars(node.GetChild(i).Cast(), scope);

                        DataType first = node.GetChild(0).Cast().TypeData;
                        DataType secont = node.GetChild(1).Cast().TypeData;

                        CheckAsNumbrer(first, node);
                        CheckAsNumbrer(secont, node);

                        if (first != secont)
                        {
                            if (first == DataType.Integer)
                                ConvertTo(node.GetChild(0).Cast(), DataType.Real);
                            else
                                ConvertTo(node.GetChild(1).Cast(), DataType.Real);

                            // теперь это точно флоат.
                            node.TypeData = DataType.Real;
                        }
                        else
                        {
                            // у обоих одинаковый тип.
                            node.TypeData = first;
                        }
                    }
                    #endregion
                    return;

                case MathLangLexer.EQUALS:
                case MathLangLexer.NEQUALS:
                case MathLangLexer.AND:
                case MathLangLexer.OR:

                case MathLangLexer.GT:
                case MathLangLexer.LT:
                case MathLangLexer.GE:
                case MathLangLexer.LE:
                    #region logicOperation
                    {
                        if ((node.Parent.Text == "Write" || node.Parent.Text == "Writeln") && node.Parent.ChildCount == 3)
                        {
                            return;
                        }
                        // Проверяю используемые переменные и определяю их тип.
                        for (int i = 0; i < node.ChildCount; i++)
                            FillVars(node.GetChild(i).Cast(), scope);

                        DataType first = node.GetChild(0).TypeData();
                        DataType secont = node.GetChild(1).TypeData();

                        bool isMustNum = false;
                        switch (node.Type)
                        {
                            case MathLangLexer.GT:
                            case MathLangLexer.LT:
                            case MathLangLexer.GE:
                            case MathLangLexer.LE:
                                isMustNum = true;
                                break;
                        }
                        if (isMustNum)
                        {
                            if (!IsNumber(first) || !IsNumber(secont))
                                throw new ApplicationException(string.Format("SSKA. Cant compare <, > type '{1}' and '{0}'", first, secont));
                        }

                        // если не равны типы, то конвертировать
                        if (first != secont)
                        {
                            // я могу конвертировать инт в флоат?
                            if (first == DataType.Real && secont == DataType.Integer)
                                ConvertTo(node.GetChild(1).Cast(), DataType.Real);
                            else if (first == DataType.Integer && secont == DataType.Real)
                                ConvertTo(node.GetChild(0).Cast(), DataType.Real);
                            else
                            {
                                throw new ApplicationException(string.Format("SSKA. Cant convert {1} to {0}", first, secont));
                            }
                        }
                        node.TypeData = DataType.Boolean;
                    }
                    #endregion
                    return;

                case MathLangLexer.ASSIGN:
                    #region assign
                    {
                        // Проверяю используемые переменные и определяю их тип.
                        for (int i = 0; i < node.ChildCount; i++)
                        {
                            FillVars(node.GetChild(i).Cast(), scope);
                            if (node.GetChild(0).Cast().TypeData == DataType.Char && node.ChildCount == 4)
                                return;
                        }
                        if (node.GetChild(0).Cast().IdentDescription.IsConst)
                            throw new ApplicationException(string.Format("An attempt to change the constant {0}",node.GetChild(0).Text));
                        DataType first = node.GetChild(0).Cast().TypeData;
                        DataType second;
                        if (node.GetChild(1).Text == "CALL" && node.GetChild(1).GetChild(0).GetChild(0).Text.Contains("Procedure"))
                            throw new ApplicationException(string.Format("Assign to procedure {0}", node.GetChild(1).GetChild(0).Text));
                        else if (node.GetChild(1).Text == "CALL" && node.GetChild(1).GetChild(0).GetChild(0).Text.Contains("Function"))
                            second = node.GetChild(1).GetChild(0).Cast().TypeData;
                        else
                            second = node.GetChild(1).Cast().TypeData;

                        if (first != second)
                        {
                            if (first == DataType.Real && second == DataType.Integer)
                            {
                                // я могу конвертировать инт в флоат.
                                ConvertTo(node.GetChild(1).Cast(), DataType.Real);
                                node.TypeData = DataType.Real;
                            }
                            else
                            {
                                throw new ApplicationException(string.Format("SSKA. Cant convert {1} to {0}", first, second));
                            }
                        }
                        else
                        {
                            node.TypeData = first;
                        }
                    }
                    #endregion
                    return;

                case MathLangLexer.WHILE:
                    #region while
                    {
                        Scope newScopeVar = new Scope(TypeScope.Non, scope);

                        for (int i = 0; i < node.ChildCount; i++)
                            FillVars(node.GetChild(i).Cast(), newScopeVar);

                        if (node.GetChild(0).TypeData() != DataType.Boolean)
                            throw new ApplicationException(string.Format("SSKA. In while condition type is {0}", node.GetChild(0).TypeData()));
                    }
                    #endregion
                    return;
                case MathLangLexer.DO:
                    #region doWhile
                    {
                        Scope newScopeVar = new Scope(TypeScope.Non, scope);

                        for (int i = 0; i < node.ChildCount; i++)
                            FillVars(node.GetChild(i).Cast(), newScopeVar);

                        if (node.GetChild(1).TypeData() != DataType.Boolean)
                            throw new ApplicationException(string.Format("SSKA. In do while condition type is {0}", node.GetChild(1).TypeData()));
                    }
                    #endregion
                    return;
                case MathLangLexer.IF:
                    #region if
                    {
                        Scope newScopeVar = new Scope(TypeScope.Non, scope);

                        for (int i = 0; i < node.ChildCount; i++)
                            FillVars(node.GetChild(i).Cast(), newScopeVar);

                        if (node.GetChild(0).TypeData() != DataType.Boolean)
                            throw new ApplicationException(string.Format("SSKA. In if condition type is {0}", node.GetChild(0).TypeData()));
                    }
                    #endregion
                    return;
                case MathLangLexer.FOR:
                    #region for
                    {
                        Scope newScopeVar = new Scope(TypeScope.Non, scope);

                        for (int i = 0; i < node.ChildCount; i++)
                            FillVars(node.GetChild(i).Cast(), newScopeVar);

                        if (node.GetChild(1).Text != "LE" && node.GetChild(1).Text != "LT")
                            throw new ApplicationException(string.Format("SSKA. In for condition type is {0}", node.GetChild(1).GetChild(0).TypeData()));
                    }
                    #endregion
                    return;
            }

            for (int i = 0; i < node.ChildCount; i++)
                FillVars(node.GetChild(i).Cast(), scope);
        }
        /// <summary>
        /// Проверить на наличие идентификатора на существование. Добавить ссылку на контекст.
        /// Получить найденый идентификатор.
        /// </summary>
        /// <param name="scope"></param>
        /// <param name="node"></param>
        /// <returns></returns>
        private List<NodeData> ArrayDescription(Scope scope, NodeData node)
        {
            List<NodeData> listSplitedVar = new List<NodeData>();
            string typeVar = node.Text;
            for (int k = 0; k < node.GetChild(0).ChildCount - 2; k++)
            {
                node.GetChild(0).GetChild(k).Cast().TypeData = StrToDataType(typeVar);
                NodeData splitedNode = new NodeData(new TokenSs(MathLangLexer.VAR, "var"));
                NodeData type = new NodeData(new TokenSs(MathLangLexer.INT, String.Format("{0}", typeVar)));
                NodeData arr = new NodeData(new TokenSs(MathLangLexer.ARRAY, "array"));
                splitedNode.AddChild(type);
                splitedNode.AddChild(arr);
                splitedNode.AddChild(node.GetChild(0).GetChild(k));
                splitedNode.AddChild(node.GetChild(0).GetChild(node.GetChild(0).ChildCount - 2));
                splitedNode.AddChild(node.GetChild(0).GetChild(node.GetChild(0).ChildCount - 1));
                listSplitedVar.Add(splitedNode);
                splitedNode.check = true;
            }
            return listSplitedVar;
        }
        private IdentDescription AddScopeInNode(Scope scope, NodeData node)
        {
            IdentDescription ident = scope.GetContainVarRecursive(node.Text);
            if (ident == null)
                throw new ApplicationException(string.Format("SSKA.Identifier '{0}' not exists", node.Text));

            InfoAboutScope infoScope = new InfoAboutScope(new TokenSs(MathLangLexer.UNKNOWN, ident.TypeIdent + ": " + ident.IndexVar));
            infoScope.LocalScope = scope;
            infoScope.Ident = ident;

            node.AddChild(infoScope);
            node.TypeData = ident.TypeData;
            node.IdentDescription = ident;
            return ident;
        }
        private void RegistrationVar(Scope scope, NodeData nodeVar, NodeData nodeVarIdent, IdentType typeIdent, string dType)
        {
            string dataType;
            bool isArray;
            bool isConst = nodeVar.Text == "const" ? true : false;
            if (nodeVar.ChildCount > 1 && nodeVar.GetChild(1).Text == "array")
            {
                isArray = true;
                dataType = nodeVar.GetChild(0).Text;
            }
            else
            {
                isArray = false;
                dataType = dType;
            }

            IdentDescription ident = scope.GetContainVarRecursive(nodeVarIdent.Text);
            if (ident != null && ident.TypeIdent != IdentType.Global)
                throw new ApplicationException(string.Format("SSKA. Identifier '{0}' already exists", nodeVarIdent.Text));
            
            ident = new IdentDescription(nodeVar, ParseDataType(dataType), typeIdent, isArray,isConst);
            nodeVarIdent.TypeData = ident.TypeData;

            scope.RegisterIdent(nodeVarIdent.Text, ident);
            nodeVarIdent.IdentDescription = ident;
        }
        private Scope RegistrationFun(Scope scope, NodeData nodeFun, NodeData nodeVarIdent)
        {
            Scope newScope = new Scope(TypeScope.Global, scope);

            IdentDescription ident = scope.GetContainVar(nodeVarIdent.Text);
            if (ident != null)
                throw new ApplicationException(string.Format("SSKA. Identifier '{0}' already exists", nodeVarIdent.Text));

            DataType dt = nodeFun.Text == "function" ? ParseDataType(nodeFun.GetChild(0).Text) : DataType.Void;
            IdentType it = nodeFun.Text == "function" ? IdentType.Function : IdentType.Procedure;
            IdentDescription newIdentFun = new IdentDescription(
                nodeFun,
                dt,
                it,
                false,
                false
                );
            scope.RegisterIdent(nodeVarIdent.Text, newIdentFun);
            //newScope.RegisterIdent(nodeVarIdent.Text, newIdentFun);
            newScope.Function = newIdentFun;

            return newScope;
        }
        private void ConvertTo(NodeData node, DataType type)
        {
            NodeData castToType = new NodeData(new TokenSs(MathLangLexer.UNKNOWN, type.ToString()));
            castToType.TypeData = type;

            NodeData convert = new NodeData(new TokenSs(MathLangLexer.CONVERT, "CONVERT"));
            node.Parent.SetChild(node.ChildIndex, convert);
            convert.TypeData = type;
            convert.AddChild(node);
            convert.AddChild(castToType);
        }
        public DataType ParseDataType(string name)
        {
            switch (name)
            {
                case "real":
                    return DataType.Real;
                case "boolean":
                    return DataType.Boolean;
                case "void":
                    return DataType.Void;
                case "integer":
                    return DataType.Integer;
                case "char":
                    return DataType.Char;
                default:
                    throw new ApplicationException(string.Format("SSKA. Unknown type {0}", name));
            }
        }
        private bool IsEqualDataType(ITree left, ITree right)
        {
            return left.Cast().TypeData == right.Cast().TypeData;
        }
        private bool IsEqualDataType(ITree left, DataType right)
        {
            return left.Cast().TypeData == right;
        }
        private bool IsNumber(ITree node)
        {
            return IsNumber(node.Cast().TypeData);
        }
        private bool IsNumber(DataType type)
        {
            return type == DataType.Integer || type == DataType.Real;
        }
        private void CheckAsNumbrer(DataType number, NodeData node)
        {
            if (number != DataType.Real && number != DataType.Integer)
                throw new ApplicationException(string.Format("Operand invalid type for operation {0}, line = {1}, pos = {2}", node.Text, node.Line, node.TokenStartIndex));
        }
        private string ParseConstType(string text)
        {
            if (text == "true" || text == "false")
                return "boolean";
            else if (text.Contains("."))
                return "real";
            else if (text.Length == 1 && !Char.IsLetterOrDigit(text[0]))
                return "char";
            else if (!text.Contains("."))
                return "integer";
            else
            {
                throw new ApplicationException("Unknown datatype!");
            }
        }
        private DataType StrToDataType(string str)
        {
            switch (str)
            {
                case "integer": return DataType.Integer;
                case "real": return DataType.Real;
                case "boolean": return DataType.Boolean;
                case "char": return DataType.Char;
                case "void": return DataType.Void;
                default: return DataType.Void;

            }
        }
        private bool IsNum(string numb)
        {
            for (int i = 0; i < numb.Length; i++)
            {
                if (!Char.IsNumber(numb[i]))
                    return false;
            }
            return true;
        }
        private void CallFunc(NodeData node,IdentDescription identFun,Scope scope)
        {
             if (identFun.TypeIdent != IdentType.Function)
                throw new ApplicationException(string.Format("SSKA. Identifier '{0}' is not function ", identFun.NameAttribut));

            // Проверить количество параметров.
            int countParamsCall = node.GetChild(1).ChildCount;
            int countParamsFun = 0;
            for (int i = 0; i < identFun.Node.GetChild(2).ChildCount; i++)
            {
                for (int k = 0; k < identFun.Node.GetChild(2).GetChild(i).ChildCount; k++)
                {
                    if (identFun.Node.GetChild(2).GetChild(i).Text == "var")
                    {
                        countParamsFun++;
                        break;
                    }
                    countParamsFun++;
                }
            }
            if (countParamsCall != countParamsFun)
                throw new ApplicationException(string.Format("SSKA. Not equals params count in function '{0}'", identFun.NameAttribut));

            // Определить тип переменных и распределить по параметрам.
            //for (int i = 1; i < node.ChildCount; i++)
             //   FillVars(node.GetChild(i).Cast(), scope);

            // К этому моменту все типы определены.
            // Сравнить типы.
            int parNum = 0;
            for (int i = 0; i < identFun.Node.GetChild(2).ChildCount; i++)
            {
                string funDataType = identFun.Node.GetChild(2).GetChild(i).Text;
                if (funDataType == "var")
                {
                    funDataType = identFun.Node.GetChild(2).GetChild(i).GetChild(0).Text;
                    IdentDescription idescr = scope.GetContainVar(node.GetChild(1).GetChild(parNum).Text);
                    string calldataType = idescr.TypeData.ToString().ToLower();
                    if (funDataType != calldataType)
                    {
                        if ((funDataType == "real") && (calldataType == "integer"))
                        {
                            ConvertTo(node.GetChild(1).GetChild(parNum).Cast(), DataType.Real);
                        }
                        else
                        {
                            throw new ApplicationException(string.Format("SSKA. Cant convert {1} to {0}", calldataType, funDataType));
                        }
                    }
                    AddScopeInNode(scope, node.GetChild(1).GetChild(parNum).Cast());
                    parNum++;
                }
                else
                {
                    string calldataType;
                    for (int k = 0; k < identFun.Node.GetChild(2).GetChild(i).ChildCount; k++)
                    {
                        if (!IsNum(node.GetChild(1).GetChild(parNum).Text))
                        {
                            IdentDescription idescr = scope.GetContainVar(node.GetChild(1).GetChild(parNum).Text);
                            calldataType = idescr.TypeData.ToString().ToLower();
                            AddScopeInNode(scope, node.GetChild(1).GetChild(parNum).Cast());
                        }
                        else
                        {
                            calldataType = ParseConstType(node.GetChild(1).GetChild(parNum).Text);
                        }
                            if (funDataType != calldataType)
                            {
                                if ((funDataType == "real") && (calldataType == "integer"))
                                {
                                    ConvertTo(node.GetChild(1).GetChild(parNum).Cast(), DataType.Real);
                                }
                                else
                                {
                                    throw new ApplicationException(string.Format("SSKA. Cant convert {1} to {0}", calldataType, funDataType));
                                }
                            }
                         parNum++;
                        }                    
                }
            }

        }
        private void CallProc(NodeData node,IdentDescription identProc,Scope scope)
        {
            if (identProc.TypeIdent != IdentType.Procedure)
                throw new ApplicationException(string.Format("SSKA. Identifier '{0}' is not procedure ", identProc.NameAttribut));

            // Проверить количество параметров.
            int countParamsCall = node.GetChild(1).ChildCount;
            int countParamsFun = 0;
            for (int i = 0; i < identProc.Node.GetChild(1).ChildCount; i++)
            {
                for (int k = 0; k < identProc.Node.GetChild(1).GetChild(i).ChildCount; k++)
                {
                    if (identProc.Node.GetChild(1).GetChild(i).Text == "var")
                    {
                        countParamsFun++;
                        break;
                    }
                    countParamsFun++;
                }
            }
            if (countParamsCall != countParamsFun)
                throw new ApplicationException(string.Format("SSKA. Not equals params count in function '{0}'", identProc.NameAttribut));

            // Определить тип переменных и распределить по параметрам.
           // for (int i = 1; i < node.ChildCount; i++)
               // FillVars(node.GetChild(i).Cast(), scope);

            // К этому моменту все типы определены.
            // Сравнить типы.
            int parNum = 0;
            for (int i = 0; i < identProc.Node.GetChild(1).ChildCount; i++)
            {
                string procDataType = identProc.Node.GetChild(1).GetChild(i).Text;
                if (procDataType == "var")
                {
                    procDataType = identProc.Node.GetChild(1).GetChild(i).GetChild(0).Text;
                    IdentDescription idescr = scope.GetContainVar(node.GetChild(1).GetChild(parNum).Text);
                    string calldataType = idescr.TypeData.ToString().ToLower();
                    if (procDataType != calldataType)
                    {
                        if ((procDataType == "real") && (calldataType == "integer"))
                        {
                            ConvertTo(node.GetChild(1).GetChild(parNum).Cast(), DataType.Real);
                        }
                        else
                        {
                            throw new ApplicationException(string.Format("SSKA. Cant convert {1} to {0}", calldataType, procDataType));
                        }
                    }
                    AddScopeInNode(scope, node.GetChild(1).GetChild(parNum).Cast());
                    parNum++;
                }
                else
                {
                    string calldataType;
                    for (int k = 0; k < identProc.Node.GetChild(1).GetChild(i).ChildCount; k++)
                    {
                        if (!IsNum(node.GetChild(1).GetChild(parNum).Text))
                        {
                            IdentDescription idescr = scope.GetContainVar(node.GetChild(1).GetChild(parNum).Text);
                            calldataType = idescr.TypeData.ToString().ToLower();
                            AddScopeInNode(scope, node.GetChild(1).GetChild(parNum).Cast());
                        }
                        else
                        {
                            calldataType = ParseConstType(node.GetChild(1).GetChild(parNum).Text);
                        }
                        if (procDataType != calldataType)
                        {
                            if ((procDataType == "real") && (calldataType == "integer"))
                            {
                                ConvertTo(node.GetChild(1).GetChild(parNum).Cast(), DataType.Real);
                            }
                            else
                            {
                                throw new ApplicationException(string.Format("SSKA. Cant convert {1} to {0}", calldataType, procDataType));
                            }
                        }
                        parNum++;
                    }
                }
            }

        }
    }
}

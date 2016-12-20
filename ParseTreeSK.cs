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
                                NodeData splitedNode = new NodeData(new TokenSs(MathLangLexer.VAR, "var"));
                                //splitedNode.AddChild(new TreeSs(new TokenSs(MathLangLexer.IDENT, typeVar)));
                                splitedNode.AddChild(node.GetChild(i));
                                splitedNode.AddChild(node.GetChild(i).GetChild(k));
                                listSplitedVar.Add(splitedNode);
                                splitedNode.check = true;
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
                        Scope newScope = RegistrationFun(scope, node, node.GetChild(2).Cast());
                        FillVars(node.GetChild(3).Cast(), newScope);// переменные
                        FillVars(node.GetChild(4).Cast(), newScope);// блок функции
                    }
                    #endregion
                    return;

                case MathLangLexer.IDENT:
                    // Все переменные должны ссылаться на зону видимости
                    AddScopeInNode(scope, node);
                    return;

                case MathLangLexer.VAR:
                    #region var
                    {
                        // Зарегать объявленные переменные
                        ITree nodeVarIdent;

                        if (node.GetChild(1).Type == MathLangLexer.IDENT)
                            nodeVarIdent = node.GetChild(1);
                        else
                            nodeVarIdent = node.GetChild(1).GetChild(0);

                        IdentType it = node.Parent.Text.Equals("PROGRAM")?IdentType.Global:IdentType.Local;

                        RegistrationVar(scope, node.Cast(), nodeVarIdent.Cast(), it);
                    }
                    #endregion
                    break;

                case MathLangLexer.PARAMS:
                    // Зарегать парметры функции и добавить зону видимости
                    RegistrationVar(scope, node, node.GetChild(1).Cast(), IdentType.Param);
                    AddScopeInNode(scope, node.GetChild(1).Cast());
                    return;
                case MathLangLexer.CALL:
                    #region CALL
                    IdentDescription identFun = AddScopeInNode(scope, node.GetChild(0).Cast());

                    if (identFun.TypeIdent != IdentType.Function)
                        throw new ApplicationException(string.Format("SSKA. Identifier '{0}' is not function", identFun.NameAttribut));

                    // Проверить количество параметров.
                    int countParamsCall = node.GetChild(1).ChildCount;
                    int countParamsFun = identFun.Node.GetChild(3).ChildCount;
                    if (countParamsCall != countParamsFun)
                        throw new ApplicationException(string.Format("SSKA. Not equals params count in function '{0}'", identFun.NameAttribut));

                    // Определить тип переменных и распределить по параметрам.
                    for (int i = 1; i < node.ChildCount; i++)
                        FillVars(node.GetChild(i).Cast(), scope);

                    // К этому моменту все типы определены.
                    // Сравнить типы.
                    NodeData paramsDeclOfFun = identFun.Node.GetChild(3).Cast();
                    for (int i = 0; i < countParamsCall; i++)
                    {
                        NodeData paramDecl = paramsDeclOfFun.GetChild(i).Cast();
                        NodeData paramCall = node.GetChild(1).GetChild(i).Cast();

                        if (!IsEqualDataType(paramDecl.GetChild(1), paramCall.GetChild(0)))
                        {
                            if (IsEqualDataType(paramDecl.GetChild(1), DataType.Real) && IsEqualDataType(paramCall.GetChild(0), DataType.Integer))
                            {
                                // я могу конвертировать инт в флоат.
                                ConvertTo(paramCall.GetChild(0).Cast(), DataType.Real);
                            }
                            else
                            {
                                throw new ApplicationException(string.Format("SSKA. Cant convert {1} to {0}", paramDecl.GetChild(1).Cast().TypeData, paramCall.GetChild(0).Cast().TypeData));
                            }
                        }
                    }
                    #endregion
                    return;

                case MathLangLexer.ADD:
                case MathLangLexer.SUB:
                case MathLangLexer.MUL:
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
                            FillVars(node.GetChild(i).Cast(), scope);

                        DataType first = node.GetChild(0).Cast().TypeData;
                        DataType second = node.GetChild(1).Cast().TypeData;

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

                        if (node.GetChild(1).ChildCount != 0 && node.GetChild(1).GetChild(0).TypeData() != DataType.Boolean)
                            throw new ApplicationException(string.Format("SSKA. In for condition type is {0}", node.GetChild(1).GetChild(0).TypeData()));
                    }
                    #endregion
                    return;
                /* case MathLangLexer.ASSIGN_ARR:
                     #region assignArray
                     {
                         for (int i = 0; i < node.ChildCount; i++)
                             FillVars(node.GetChild(i).Cast(), scope);

                         IdentDescription array = scope.GetContainVarRecursive(node.GetChild(0).Text);
                         if (!array.IsArray)
                             throw new ApplicationException(string.Format("SSKA. {0} is not array", node.GetChild(0).Text));
                         if (node.GetChild(1).TypeData() != DataType.Int)
                             throw new ApplicationException(string.Format("SSKA. {0} have index not integer.", node.GetChild(0).Text));

                         DataType first = array.TypeData;
                         node.TypeData = first;			// Сразу присвоим, чтобы потом не вызывать два раза в разных моментах кода.

                         // Костыль, если значение массива используется как значение.
                         if (node.ChildCount == 2)
                         {
                             return;
                         }

                         DataType secont = node.GetChild(2).Cast().TypeData;

                         if (first != secont)
                         {
                             if (first == DataType.Float && secont == DataType.Int)
                             {
                                 // я могу конвертировать инт в флоат.
                                 ConvertTo(node.GetChild(2).Cast(), DataType.Float);
                                 node.TypeData = DataType.Float;
                             }
                             else
                             {
                                 throw new ApplicationException(string.Format("SSKA. Cant convert {1} to {0}", first, secont));
                             }
                         }
                     }
                     #endregion
                     return;*/
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

            //node.Text = node.Text + " " + ident.TypeIdent + ": " + ident.IndexVar;
            // NodeData nd = new NodeData(new TokenSs(node.Type, node.Text + " " + ident.TypeIdent + ": " + ident.IndexVar));
            //node.Parent.SetChild(node.ChildIndex, nd);

            return ident;
        }
        private void RegistrationVar(Scope scope, NodeData nodeVar, NodeData nodeVarIdent, IdentType typeIdent)
        {
            string dataType;
            bool isArray;
           /* if (nodeVar.GetChild(0).Type == MathLangLexer.ARRAY_TYPE)
            {
                isArray = true;
                dataType = nodeVar.GetChild(0).GetChild(0).Text;
            }
            else
            {*/
                isArray = false;
                dataType = nodeVar.GetChild(0).Text;
            //}

            IdentDescription ident = scope.GetContainVarRecursive(nodeVarIdent.Text);
            if (ident != null && ident.TypeIdent != IdentType.Global)
                throw new ApplicationException(string.Format("SSKA. Identifier '{0}' already exists", nodeVarIdent.Text));



            ident = new IdentDescription(nodeVar, ParseDataType(dataType), typeIdent, isArray);
            nodeVarIdent.TypeData = ident.TypeData;

            scope.RegisterIdent(nodeVarIdent.Text, ident);
        }
        private Scope RegistrationFun(Scope scope, NodeData nodeFun, NodeData nodeVarIdent)
        {
            Scope newScope = new Scope(TypeScope.Local, scope);

            IdentDescription ident = scope.GetContainVar(nodeVarIdent.Text);
            if (ident != null)
                throw new ApplicationException(string.Format("SSKA. Identifier '{0}' already exists", nodeVarIdent.Text));

            IdentDescription newIdentFun = new IdentDescription(
                nodeFun,
                ParseDataType(nodeFun.GetChild(1).Text),
                IdentType.Function,
                false
                );
            scope.RegisterIdent(nodeVarIdent.Text, newIdentFun);

           // newScope.Function = newIdentFun;

            return newScope;
        }
        private void ConvertTo(NodeData node, DataType type)
        {
            NodeData castToType = new NodeData(new TokenSs(MathLangLexer.UNKNOWN, type.ToString()));
            castToType.TypeData = type;

            NodeData convert = new NodeData(new TokenSs(MathLangLexer.UNKNOWN, "CONVERT"));
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
    }
}
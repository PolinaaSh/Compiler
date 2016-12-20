using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathLang
{
    /*public enum IdentType
    {
        Global,
        Local,
        Param,
        Function,
        Procedure
    }*/

   /* public enum DataType
    {
        Void,
        Integer,
        Real,
        Boolean,
        Char
    }*/

    public class Ident
    {
        public string Name { get; set; }
        public IdentType IdentType { get; set; }
        public DataType DataType { get; set; }
        public MathAstNode Node { get; set; }
        public int IdentNumber { get; set; }
        public bool IsArray { get; set; }

        public Ident(string name, IdentType identType, DataType dataType, MathAstNode node, int identNumber)
        {
            Name = name;
            IdentType = identType;
            DataType = dataType;
            Node = node;
            IdentNumber = identNumber;
        }
        public Ident(string name, IdentType identType, DataType dataType, MathAstNode node, int identNumber, bool array)
        {
            Name = name;
            IdentType = identType;
            DataType = dataType;
            Node = node;
            IdentNumber = identNumber;
            IsArray = array;
        }
    }

    public class Context
    {
        private Context parentContext;

        private Dictionary<string, Ident> idents = new Dictionary<string, Ident>();

        public Context(Context parentContext)
        {
            this.parentContext = parentContext;
        }

        public Ident this[string name]
        {
            get
            {
                return idents.ContainsKey(name) ? idents[name] :
                           parentContext != null ? parentContext[name] : null;
            }
            set
            {
                idents[name] = value;
            }
        }

        public Ident InThisContext(string name)
        {
            return idents.ContainsKey(name) ? idents[name] : null;
        }

        private Ident function = null;

        public Ident Function
        {
            get
            {
                return function != null ? function :
                           parentContext != null ? parentContext.Function : null;
            }
            set
            {
                function = value;
            }
        }

        public Context ParentContext
        {
            get
            {
                return parentContext;
            }
        }
    }

    class SemanticChecker
    {
        private static int globalCount = -1;
        private static int funcCount = -1;
        private static int procCount = -1;
        private static DataType strToDataType(string type)
        {
            switch (type)
            {
                case "integer":
                    return DataType.Integer;
                case "real":
                    return DataType.Real;
                case "boolean":
                    return DataType.Boolean;
                case "char":
                    return DataType.Char;
                case "void":
                case "":
                    return DataType.Void;
                default:
                    throw new ApplicationException("Invalid data type");
            }
        }
        public static string dataTypeToStr(DataType dataType)
        {
            switch (dataType)
            {
                case DataType.Integer:
                    return "integer";
                case DataType.Real:
                    return "real";
                case DataType.Boolean:
                    return "boolean";
                case DataType.Char:
                    return "char";
                case DataType.Void:
                    return "void";
                default:
                    return "unknown";
            }
        }

        private static void convert(MathAstNode node, DataType dataType)
        {
            MathAstNode convert = new MathAstNode(new Antlr.Runtime.CommonToken(MathLangLexer.CALL, "CONVERT"));
            node.Parent.SetChild(node.ChildIndex, convert);
            convert.DataType = dataType;
            convert.AddChild(node);
            convert.AddChild(new MathAstNode(new Antlr.Runtime.CommonToken(MathLangLexer.IDENT, dataTypeToStr(dataType))));
        }
        public static void CheckBlock(MathAstNode node, Context context)
        {
            for (int i = 0; i < node.ChildCount; i++)
                Check((MathAstNode)node.GetChild(i), context);
        }
        public static DataType Check(MathAstNode node, Context context)
        {
            switch (node.Type)
            {
                case MathLangLexer.PROGRAM:
                    {
                        return ProgramNode(node, context);
                    }
                case MathLangLexer.BLOCK:
                    {
                        return BlocNode(node, context);
                    }
                case MathLangLexer.CONST_:
                    {
                        return ConstNode(node, context);
                    }

                case MathLangLexer.VAR:
                    {
                        return VarNode(node, context);
                    }

                case MathLangLexer.FUNC:
                    {
                        return FuncNode(node, context);
                    }
                case MathLangLexer.PROC:
                    {
                        return ProcNode(node, context);
                    }
                case MathLangLexer.CALL:
                    {
                        return CallNode(node, context);
                    }
                case MathLangLexer.IDENT:
                    {
                        return IdentNode(node, context);
                    }
                case MathLangLexer.NUMBER:
                    {
                        return NumberNode(node, context);
                    }
                case MathLangLexer.TRUE:
                case MathLangLexer.FALSE:
                    {
                        return LogicType(node, context);
                    }
                case MathLangLexer.ASSIGN:
                    {
                        return AssignNode(node, context);
                    }
                case MathLangLexer.ADD:
                case MathLangLexer.SUB:
                case MathLangLexer.MUL:
                case MathLangLexer.DIVIDE:
                case MathLangLexer.DIV:
                case MathLangLexer.MOD:
                case MathLangLexer.GE:
                case MathLangLexer.LE:
                case MathLangLexer.NEQUALS:
                case MathLangLexer.EQUALS:
                case MathLangLexer.GT:
                case MathLangLexer.LT:
                    {
                        return MathAndCompare(node, context);
                    }
                case MathLangLexer.AND:
                case MathLangLexer.OR:
                    {
                        return AndOrLogicNode(node, context);
                    }
                case MathLangLexer.IF:
                    {
                        return IfNode(node, context);
                    }
                case MathLangLexer.WHILE:
                    {
                        return WhileNode(node, context);
                    }
                case MathLangLexer.FOR:
                    {
                        return ForNode(node, context);
                    }
                case MathLangLexer.REPEAT:
                    {
                        return RepeatNode(node, context);
                    }
                default:
                    {
                        throw new ApplicationException("Unknow token type");
                    }
            }
        }
        private static DataType VarNode(MathAstNode node, Context context )
        {
            int localCount = -1;
            List<MathAstNode> nodes = new List<MathAstNode>();
            if (!node.check)
            {
                for (int k = 0; k < node.ChildCount; k++)
                {
                    DataType dataType = strToDataType(node.GetChild(k).Text);
                    for (int i = 0; i < node.GetChild(k).ChildCount; i++)
                    {
                        MathAstNode temp = (MathAstNode)node.GetChild(k).GetChild(i);
                        if (temp.Text.Equals("array"))
                        {
                            nodes.AddRange(ArrayDefinition(node, context, k));
                            break;
                        }
                        Ident ident = context.InThisContext(temp.Text);
                        if (ident != null)
                            throw new ApplicationException(string.Format("Identifier {0} already exists", temp.Text));
                        MathAstNode var = new MathAstNode(new Antlr.Runtime.CommonToken(MathLangLexer.VAR, "VAR"));
                        var.AddChild(new MathAstNode(new Antlr.Runtime.CommonToken(MathLangLexer.IDENT, dataTypeToStr(dataType))));
                        var.GetChild(0).AddChild(temp);
                        nodes.Add(var);
                        var.check = true;
                        string name = nodes[nodes.Count - 1].GetChild(0).GetChild(0).Text;
                        context[name] = new Ident(name, context.ParentContext == null ? IdentType.Global : IdentType.Local, dataType, nodes[nodes.Count - 1], context.ParentContext == null ? ++globalCount : ++localCount);
                        ((MathAstNode)nodes[nodes.Count - 1].GetChild(0).GetChild(0)).Text += AddType(context[name]);
                    }
                }
                Antlr.Runtime.Tree.CommonTree tree = new Antlr.Runtime.Tree.CommonTree();
                foreach (MathAstNode n in nodes)
                    tree.AddChild(n);
                node.Parent.ReplaceChildren(node.ChildIndex, node.ChildIndex, tree);
            }
            return DataType.Void;
        }
        private static DataType ProgramNode(MathAstNode node, Context context)
        {
            if (context == null)
                context = new Context(context);
            CheckBlock(node, context);
            return DataType.Void;
        }
        private static DataType BlocNode(MathAstNode node, Context context)
        {
            context = new Context(context);
            CheckBlock(node, context);
            return DataType.Void;
        }
        private static DataType ConstNode(MathAstNode node, Context context)
        {
            int localCount = -1;
            List<MathAstNode> nodes = new List<MathAstNode>();
            if (!node.check)
            {
                for (int i = 0; i < node.ChildCount; i++)
                {
                    MathAstNode temp = (MathAstNode)node.GetChild(i);
                    Ident ident = context.InThisContext(temp.Text);
                    if (ident != null)
                        throw new ApplicationException(string.Format("Identifier {0} already exists", temp.Text));
                    MathAstNode constValue = (MathAstNode)temp.GetChild(0);
                    DataType constType = DefineDataType(constValue);
                    MathAstNode dataType = new MathAstNode(new Antlr.Runtime.CommonToken(MathLangLexer.IDENT, dataTypeToStr(constType)));
                    dataType.AddChild(constValue);
                    temp.ReplaceChildren(0, 0, dataType);
                    MathAstNode cnst = new MathAstNode(new Antlr.Runtime.CommonToken(MathLangLexer.CONST_, "CONST"));
                    cnst.AddChild(temp);
                    nodes.Add(cnst);
                    cnst.check = true;
                    string name = nodes[nodes.Count - 1].GetChild(0).Text;
                    context[name] = new Ident(name, context.ParentContext == null ? IdentType.Global : IdentType.Local, constType, nodes[nodes.Count - 1], context.ParentContext == null ? ++globalCount : ++localCount);
                    constValue.Text += AddType(context[name]);
                }
                Antlr.Runtime.Tree.CommonTree tree = new Antlr.Runtime.Tree.CommonTree();
                foreach (MathAstNode n in nodes)
                    tree.AddChild(n);
                node.Parent.ReplaceChildren(node.ChildIndex, node.ChildIndex, tree);
            }
            return DataType.Void;
        }
        private static DataType IdentNode(MathAstNode node, Context context)
        {
            Ident ident = context[node.Text];
            if (ident == null)
                throw new ApplicationException(string.Format("Unknown identifier {0}", node.Text));
            node.Text += AddType(ident);
            node.DataType = ident.DataType;
            return node.DataType;
        }
        private static DataType AssignNode(MathAstNode node, Context context)
        {
            Ident ident = context[node.GetChild(0).Text];
            ((MathAstNode)node.GetChild(0)).Text += AddType(ident);
            if (ident == null)
                throw new ApplicationException(string.Format("Unknown identifier {0}", node.GetChild(0).Text));
            if (ident.IdentType == IdentType.Function && context.Function.IdentType != IdentType.Function)
                throw new ApplicationException(string.Format("Assign to function {0}", node.GetChild(0).Text));
            if (ident.IsArray)
            {
                int rightIndex = Convert.ToInt32(ident.Node.GetChild(0).GetChild(1).GetChild(0).Text);
                int factIndex = Convert.ToInt32(node.GetChild(0).GetChild(0).GetChild(0).Text);
                if (factIndex > rightIndex || factIndex < 1)
                    throw new ApplicationException(string.Format("Out of range in array {0}", ident.Name));
            }
            DataType rightDataType = Check((MathAstNode)node.GetChild(1), context);
            if (ident.DataType != rightDataType)
            {
                if (ident.DataType == DataType.Real && rightDataType == DataType.Integer)
                    convert((MathAstNode)node.GetChild(1), DataType.Real);
                else
                    throw new ApplicationException(string.Format("Assign incopotible types {0} {1}", dataTypeToStr(ident.DataType), dataTypeToStr(rightDataType)));
            }
            return DataType.Void;
        }
        private static DataType NumberNode(MathAstNode node, Context context)
        {
            node.DataType = node.Text.Contains(".") ? DataType.Real : DataType.Integer;
            return node.DataType;
        }
        private static DataType MathAndCompare(MathAstNode node, Context context)
        {
            bool compareOperation = true;
            switch (node.Type)
            {
                case MathLangLexer.ADD:
                case MathLangLexer.SUB:
                case MathLangLexer.MUL:
                case MathLangLexer.DIVIDE:
                case MathLangLexer.DIV:
                case MathLangLexer.MOD:
                    compareOperation = false;
                    break;
            }

            DataType leftDataType = Check((MathAstNode)node.GetChild(0), context);
            DataType rightDataType = Check((MathAstNode)node.GetChild(1), context);
            if (leftDataType != DataType.Real && leftDataType != DataType.Integer)
                throw new ApplicationException(string.Format("Left operand invalid type for operation {0}, line = {1}, pos = {2}", node.Text, node.Line, node.TokenStartIndex));
            if (rightDataType != DataType.Real && rightDataType != DataType.Integer)
                throw new ApplicationException(string.Format("Right operand invalid type for operation {0}, line = {1}, pos = {2}", node.Text, node.Line, node.TokenStartIndex));
            if (leftDataType == DataType.Real)
            {
                if (rightDataType == DataType.Integer)
                    convert((MathAstNode)node.GetChild(1), DataType.Real);
                node.DataType = compareOperation ? DataType.Boolean : DataType.Real;
                return node.DataType;
            }
            if (rightDataType == DataType.Real)
            {
                if (leftDataType == DataType.Integer)
                    convert((MathAstNode)node.GetChild(0), DataType.Real);
                node.DataType = compareOperation ? DataType.Boolean : DataType.Real;
                return node.DataType;
            }
            node.DataType = compareOperation ? DataType.Boolean : DataType.Integer;
            return node.DataType;
        }
        private static DataType CallNode(MathAstNode node, Context context)
        {
            Ident ident = context[node.GetChild(0).Text];
            if (ident == null)
                throw new ApplicationException(string.Format("Unknown identifier {0}", node.GetChild(0).Text));
            if (ident.IdentType != IdentType.Function && ident.IdentType != IdentType.Procedure)
                throw new ApplicationException(string.Format("Identifier {0} is not function or procedure", node.GetChild(0).Text));
            int ind = ident.IdentType == IdentType.Procedure ? 1 : 2;
            int rightParamCount = node.GetChild(ind).ChildCount;
            if (ind == 1)// if node is procedure
            {
                if (node.GetChild(1).ChildCount != rightParamCount)
                    throw new ApplicationException(string.Format("Not equals params count in procedure {0}", node.GetChild(0).Text));
                for (int i = 0; i < ident.Node.GetChild(ind).ChildCount; i++)
                {
                        DataType formalDataType = ident.Node.GetChild(ind).GetChild(i).Text.Equals("VAR") ? strToDataType(ident.Node.GetChild(ind).GetChild(i).GetChild(0).Text) : strToDataType(ident.Node.GetChild(ind).GetChild(i).Text);
                        DataType factDataType = Check((MathAstNode)node.GetChild(1).GetChild(i), context);
                        if (formalDataType != factDataType)
                        {
                            if (formalDataType == DataType.Real && factDataType == DataType.Integer)
                                convert((MathAstNode)node.GetChild(ind).GetChild(i), DataType.Real);
                            else
                                throw new ApplicationException(string.Format("In procedure {0} param {1} incopotible types {2} {3}", node.GetChild(0).Text, i, dataTypeToStr(formalDataType), dataTypeToStr(factDataType)));
                        }
                }
            }
            else //if node is function
            {
                if (node.GetChild(1).ChildCount != rightParamCount)
                    throw new ApplicationException(string.Format("Not equals params count in function {0}", node.GetChild(0).Text));
                for (int i = 0; i < ident.Node.GetChild(ind).ChildCount; i++)
                {
                    int to = ident.Node.GetChild(ind).GetChild(i).ChildCount;
                    DataType formalDataType = strToDataType(ident.Node.GetChild(ind).GetChild(i).Text);
                        DataType factDataType = Check((MathAstNode)node.GetChild(1).GetChild(i), context);
                        if (formalDataType != factDataType)
                        {
                            if (formalDataType == DataType.Real && factDataType == DataType.Integer)
                                convert((MathAstNode)node.GetChild(ind).GetChild(i), DataType.Real);
                            else
                                throw new ApplicationException(string.Format("In function {0} param {1} incopotible types {2} {3}", node.GetChild(0).Text, i, dataTypeToStr(formalDataType), dataTypeToStr(factDataType)));
                        }
       
                }
            }
            ((MathAstNode)node.GetChild(0)).Text += AddType(ident);
            DataType res;
            return  res = ident.Node.GetChild(ind).ChildCount!=0?strToDataType(ident.Node.GetChild(ind).GetChild(0).Text): strToDataType("void");
        }
        private static DataType AndOrLogicNode(MathAstNode node, Context context)
        {
            DataType leftDataType = Check((MathAstNode)node.GetChild(0), context);
            DataType rightDataType = Check((MathAstNode)node.GetChild(1), context);
            if (leftDataType != DataType.Boolean && rightDataType != DataType.Boolean)
                throw new ApplicationException(string.Format("{0} operator with type {1}, {2}", node.Text, dataTypeToStr(leftDataType), dataTypeToStr(rightDataType)));
            node.DataType = DataType.Boolean;
            return node.DataType;
        }
        private static DataType LogicType(MathAstNode node, Context context)
        {
            node.DataType = DataType.Boolean;
            return node.DataType;
        }
        private static DataType IfNode(MathAstNode node, Context context)
        {
            DataType condDataType = Check((MathAstNode)node.GetChild(0), context);
            if (condDataType != DataType.Boolean)
                throw new ApplicationException(string.Format("In if condition type is {0}", dataTypeToStr(condDataType)));
            Check((MathAstNode)node.GetChild(1), context);
            if (node.ChildCount == 3)
                Check((MathAstNode)node.GetChild(2), context);
            return DataType.Void;
        }
        private static DataType WhileNode(MathAstNode node, Context context)
        {
            DataType condDataType = Check((MathAstNode)node.GetChild(0), context);
            if (condDataType != DataType.Boolean)
                throw new ApplicationException(string.Format("In while condition type is {0}", dataTypeToStr(condDataType)));
            Check((MathAstNode)node.GetChild(1), context);
            return DataType.Void;
        }
        private static DataType ForNode(MathAstNode node, Context context)
        {
            context = new Context(context);
            for (int i = 0; i < node.ChildCount;i++ )
                Check((MathAstNode)node.GetChild(i), context);
            return DataType.Void;
        }
        private static DataType RepeatNode(MathAstNode node, Context context)
        {
            DataType condDataType = Check((MathAstNode)node.GetChild(1), context);
            if (condDataType != DataType.Boolean)
                throw new ApplicationException(string.Format("In while condition type is {0}", dataTypeToStr(condDataType)));
            Check((MathAstNode)node.GetChild(0), context);
            return DataType.Void;
        }
        private static DataType FuncNode(MathAstNode node, Context context)
        {
            if (node.ChildCount < 4)
            {
                string name = node.GetChild(1).Text;
                Ident ident = context[name];
                if (ident != null)
                    throw new ApplicationException(string.Format("Identifier {0} already exists", name));
                DataType dataType = strToDataType(node.GetChild(0).Text);
                Ident func = new Ident(name, IdentType.Function, dataType, node, -1);
                context[name] = func;
                context = new Context(context);
            }
            else
            {
                int paramCount = -1;
                DataType dataType = strToDataType(node.GetChild(0).Text);
                string name = node.GetChild(1).Text;
                Ident ident = context[name];
                if (ident != null)
                    throw new ApplicationException(string.Format("Identifier {0} already exists", name));
                Ident func = new Ident(name, IdentType.Function, dataType, node, ++funcCount);
                context[name] = func;
                context = new Context(context);
                MathAstNode _params = (MathAstNode)node.GetChild(2);
                for (int i = 0; i < _params.ChildCount; i++)
                {
                    DataType paramDataType = strToDataType(_params.GetChild(i).Text);
                    for (int k = 0; k < _params.GetChild(i).ChildCount; k++)
                    {
                        string paramName = _params.GetChild(i).GetChild(k).Text;
                        MathAstNode paramN = (MathAstNode)_params.GetChild(i).GetChild(k);
                        if (paramDataType == DataType.Void)
                            throw new ApplicationException(string.Format("In function {0} void param {1}", name, paramName));
                        context[paramName] = new Ident(paramName, IdentType.Param, paramDataType, (MathAstNode)_params.GetChild(i).GetChild(k), ++paramCount);
                        paramN.Text += AddType(context[paramName]);
                    }
                }
                context.Function = func;
                for (int i = 3; i < node.ChildCount; i++)
                    Check((MathAstNode)node.GetChild(i), context);
            }
            return DataType.Void;
        }
        private static DataType ProcNode(MathAstNode node, Context context)
        {
            if (node.ChildCount < 3)
            {
                string name = node.GetChild(0).Text;
                Ident ident = context[name];
                if (ident != null)
                    throw new ApplicationException(string.Format("Identifier {0} already exists", name));
                Ident proc = new Ident(name, IdentType.Procedure, DataType.Void, node, -1);
                context[name] = proc;
                context = new Context(context);
            }
            else
            {
                int paramCount = -1;
                string name = node.GetChild(0).Text;
                Ident ident = context[name];
                if (ident != null)
                    throw new ApplicationException(string.Format("Identifier {0} already exists", name));
                Ident proc = new Ident(name, IdentType.Procedure, DataType.Void, node, ++procCount);
                context[name] = proc;
                context = new Context(context);
                ((MathAstNode)node.GetChild(0)).Text += AddType(proc);
                MathAstNode _params = (MathAstNode)node.GetChild(1);
                MathAstNode type;
                List<MathAstNode> nodes = new List<MathAstNode>();
                for (int i = 0; i < _params.ChildCount; i++)
                {
                    int to =0;
                        DataType paramDataType = _params.GetChild(i).Text.Equals("var") ? strToDataType(_params.GetChild(i).GetChild(0).Text) : strToDataType(_params.GetChild(i).Text);
                    for (int k = 0; k < (to =_params.GetChild(i).Text.Equals("var")?_params.GetChild(i).GetChild(0).ChildCount:_params.GetChild(i).ChildCount); k++)
                        {
                            string paramName = _params.GetChild(i).Text.Equals("var") ? _params.GetChild(i).GetChild(0).GetChild(k).Text : _params.GetChild(i).GetChild(k).Text;
                            type = new MathAstNode(new Antlr.Runtime.CommonToken(MathLangLexer.IDENT, dataTypeToStr(paramDataType)));
                            MathAstNode paramN = _params.GetChild(i).Text.Equals("var") ? (MathAstNode)_params.GetChild(i).GetChild(0).GetChild(k) : (MathAstNode)_params.GetChild(i).GetChild(k);
                            if (paramDataType == DataType.Void)
                                throw new ApplicationException(string.Format("In procdure {0} void param {1}", name, paramName));
                            if (!_params.GetChild(i).Text.Equals("var"))
                            {
                                context[paramName] = new Ident(paramName, IdentType.Param, paramDataType, (MathAstNode)_params.GetChild(i).GetChild(k), ++paramCount);
                                type.AddChild(paramN);
                            }
                            else
                            {
                                context[paramName] = new Ident(paramName, IdentType.Param, paramDataType, (MathAstNode)_params.GetChild(i).GetChild(0).GetChild(k), ++paramCount);
                                type = new MathAstNode(new Antlr.Runtime.CommonToken(MathLangLexer.VAR, "VAR"));
                                MathAstNode n = new MathAstNode(new Antlr.Runtime.CommonToken(MathLangLexer.IDENT, dataTypeToStr(paramDataType)));
                                n.AddChild(paramN);
                                type.AddChild(n);
                            }
                            nodes.Add(type);
                            paramN.Text += AddType(context[paramName]);
                        }
                    }
                context.Function = proc;
                for (int i = 2; i < node.ChildCount; i++)
                    Check((MathAstNode)node.GetChild(i), context);
                if (_params.ChildCount != 0)
                {
                    Antlr.Runtime.Tree.CommonTree tree = new Antlr.Runtime.Tree.CommonTree();
                    foreach (MathAstNode n in nodes)
                        tree.AddChild(n);
                    _params.ReplaceChildren(0, _params.ChildCount - 1, tree);
                }
               
            }
            return DataType.Void;
        }
        private static DataType DefineDataType(MathAstNode node)
        {
            try
            {
                if (node.Text.Length == 1 && char.IsLetter(node.Text, 0))
                {
                    return DataType.Char;
                }
                else if (node.Text.Equals("true") || node.Text.Equals("false"))
                    return DataType.Boolean;
                else if (node.Text.Contains("."))
                    return DataType.Real;
                else if (!node.Text.Contains("."))
                    return DataType.Integer;
                else
                {
                    throw new ApplicationException(string.Format("Unknown datatype {0}", node.Text));
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return DataType.Void;
            }
        }
        private static String AddType(Ident ident)
        {
            string res = ident.IdentNumber != -1 ? "   " + ident.DataType + " " + ident.IdentType + " " + ident.IdentNumber : "   " + ident.DataType + " " + "Standart";
            return res;
        }
        private static List<MathAstNode> ArrayDefinition(MathAstNode node, Context context, int a)
        {
            int localCount = -1;
            List<MathAstNode> nodes = new List<MathAstNode>();
            MathAstNode to = (MathAstNode)node.GetChild(a).GetChild(0).GetChild(node.GetChild(a).GetChild(0).ChildCount - 1);
            DataType dataType = strToDataType(node.GetChild(a).Text);
            for (int i = 0; i < node.GetChild(a).GetChild(0).ChildCount - 2; i++)
            {
                MathAstNode arr = (MathAstNode)node.GetChild(a).GetChild(0).GetChild(i);
                String arrName = node.GetChild(a).GetChild(0).GetChild(i).Text;
                Ident ident = context.InThisContext(arrName);
                if (ident != null)
                    throw new ApplicationException(string.Format("Array {0} already exists", arrName));
                MathAstNode var = new MathAstNode(new Antlr.Runtime.CommonToken(MathLangLexer.VAR, "VAR"));
                var.AddChild(new MathAstNode(new Antlr.Runtime.CommonToken(MathLangLexer.IDENT, dataTypeToStr(dataType))));
                var.GetChild(0).AddChild(new MathAstNode(new Antlr.Runtime.CommonToken(MathLangLexer.ARRAY, "ARRAY")));
                var.GetChild(0).AddChild(node.GetChild(a).GetChild(0).GetChild(i));
                var.GetChild(0).GetChild(1).AddChild(to);
                nodes.Add(var);
                var.check = true;
                context[arrName] = new Ident(arrName, context.ParentContext == null ? IdentType.Global : IdentType.Local, dataType, nodes[nodes.Count - 1], context.ParentContext == null ? ++globalCount : ++localCount, true);
                arr.Text += AddType(context[arrName]);
            }
            return nodes;
        }
    }
}

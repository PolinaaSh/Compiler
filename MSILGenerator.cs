using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MathLang
{
    class MSILGenerator
    {

        private  int lineNum = 0;
        private NodeData curFunc;
        private StringBuilder arr = new StringBuilder();
       private static  Dictionary<char, string> charValue = new Dictionary<char, string>();

        public static string ToMsilType(String type)
        {
            if (type == "integer") return "int32";
            else if (type == "real") return "float32";
            else return type;
        }

        public static string Gen(NodeData program)
        {
            FullDict();
            StringBuilder sb = new StringBuilder();
            sb.Append(@"
.assembly program
{
}
.class public auto ansi beforefieldinit Program
       extends [mscorlib]System.Object
{
");
            MSILGenerator generator = new MSILGenerator();
            generator.Gen(program, sb);
            sb.Append(@"
}
"           );
            return sb.ToString();
        }

        private static int GetVarNum(NodeData node)
        {
            return ((InfoAboutScope)node.GetChild(0)).Ident.IndexVar;
        }

        private  void 
            GenLocalVars(NodeData node, StringBuilder sb)
        {
            if (node.Type == MathLangLexer.VAR && node.Parent.Text !="PARAMS")
            {
                int num;
                string type = ToMsilType(node.GetChild(0).Text);
                if (node.GetChild(1).Text == "array")
                {
                    num = GetVarNum((NodeData)node.GetChild(2));
                    sb.Append(string.Format("      [{0}] {1}[],\n", num, type));
                }
                else
                {
                    num = GetVarNum((NodeData)node.GetChild(1));
                    sb.Append(string.Format("      [{0}] {1},\n", num, type));
                }
            }
            else
                for (int i = 0; i < node.ChildCount; i++)
                    GenLocalVars((NodeData)node.GetChild(i), sb);
         }
        private  void GenGlobalVars(NodeData node, StringBuilder sb)
        {
            if (node.Type == MathLangLexer.VAR)
            {
                    string type = ToMsilType(node.GetChild(0).Text);
                    if (node.GetChild(1).Text == "array")
                    {
                        sb.Append(string.Format("  .field public static {0}[] {1}\n", type, node.GetChild(2).Text));
                        arr.Append(string.Format("    L_{0:D6}: ldc.i4 {1}\n", lineNum++, node.GetChild(4).Text));
                        arr.Append(string.Format("    L_{0:D6}: newarr     [mscorlib]System.Int32\n", lineNum++));
                        arr.Append(string.Format("    L_{0:D6}: stsfld     {1}[] Program::{2}\n", lineNum++, ToMsilType(node.GetChild(0).Text), node.GetChild(2).Text));
                    }
                    else
                    {
                        sb.Append(string.Format("  .field public static {0} {1}\n", type, node.GetChild(1).Text));
                    }
           }
            else
                for (int i = 0; i < node.ChildCount; i++)
                    GenGlobalVars((NodeData)node.GetChild(i), sb);
        }
        private void GenGlobalConst(NodeData node, StringBuilder sb)
        {
            if (node.Type == MathLangLexer.CONST_)
            {
                string type = ToMsilType(node.GetChild(0).Text);
                int num;
                num = GetVarNum((NodeData)node.GetChild(1));
                sb.Append(string.Format("    .field public static [{0}] {1},\n", type, num));
                sb.Append(string.Format("    .method private hidebysig specialname rtspecialname static void .cctor() cil managed {.maxstack 8 \n"));
                sb.Append(String.Format("    L_{0:D6}: ldc.i4.{1}\n ",lineNum++,num));
                sb.Append(String.Format("    L_{0:D6}: stsfld int32 commands.Program::a\n }\n ",lineNum++));
            }
        }

        private void Gen(NodeData node, StringBuilder sb)
        {
            //StringBuilder sb0;

            if (node == null)
                return;

            switch (node.Type)
            {
                case MathLangLexer.PROGRAM:
                    GenProgram(node, sb);
                    break;
                case MathLangLexer.BLOCK:
                case MathLangLexer.SCOPEBLOCK:
                    GenBlock(node, sb);
                    break;

                case MathLangLexer.VAR:
                    GenVar(node, sb);
                    break;
                case MathLangLexer.BEGIN:
                    GenBegin(node, sb);
                    break;

                case MathLangLexer.FUNC:
                    GenFunc(node, sb);
                    break;

                case MathLangLexer.PROC:
                    GenProc(node, sb);
                    break;

                case MathLangLexer.CALL:
                    GenCall(node, sb);
                    break;

                case MathLangLexer.NUMBER:
                    GenNumber(node, sb);
                    break;

                case MathLangLexer.IDENT:
                    GenIdent(node, sb);
                    break;

                case MathLangLexer.ASSIGN:
                    GenAssign(node, sb);                   
                    break;

                case MathLangLexer.EQUALS:
                    GenEquals(node, sb);
                    break;

                case MathLangLexer.NEQUALS:
                    GenNequals(node, sb);
                    break;

                case MathLangLexer.AND:
                    GenAnd(node, sb);
                    break;

                case MathLangLexer.OR:
                    GenOr(node, sb);
                    break;

                case MathLangLexer.ADD:
                    GenAdd(node, sb);
                    break;

                case MathLangLexer.SUB:
                    GenSub(node, sb);
                    break;

                case MathLangLexer.MUL:
                    GenMul(node, sb);
                    break;

                case MathLangLexer.DIVIDE:
                    GenDivide(node, sb);
                    break;


                case MathLangLexer.DIV:
                    GenDiv(node, sb);
                    break;

                case MathLangLexer.MOD:
                    GenMod(node, sb);
                    break;

                case MathLangLexer.LT:
                    GenLess(node, sb);
                    break;
                case MathLangLexer.LE:
                    GenLessEquals(node, sb);
                    break;

                case MathLangLexer.GT:
                    GenGreater(node,sb);
                    break;

                case MathLangLexer.GE:
                    GenGreaterEquals(node,sb);
                    break;

                case MathLangLexer.PRINT:
                    GenPrint(node,sb);
                    break;

                case MathLangLexer.PRINTSTR:
                    GenPrintStr(node, sb);
                    break;

                case MathLangLexer.ELSIF:
                    GenElsif(node, sb);
                    break;
                case MathLangLexer.IF:
                    GenIf(node, sb);
                    break;

                case MathLangLexer.ELSE:
                    GenElse(node, sb);
                    break;

                case MathLangLexer.FOR:
                    GenFor(node,sb);
                    break;

                case MathLangLexer.WHILE:
                    GenWhile(node, sb);
                    break;

                case MathLangLexer.REPEAT:
                    GenRepeat(node, sb);
                    break;

                default:
                    break;
            }
        }
        public void GenProgram(NodeData node,StringBuilder sb)
        {
            for (int i = 0; i < node.ChildCount; i++)
            {
                if (node.GetChild(i).Text == "var" || node.GetChild(i).Text == "const")
                {
                    GenGlobalVars((NodeData)node.GetChild(i), sb);
                }
                else
                    Gen((NodeData)node.GetChild(i), sb);
            }
        }
        public void GenBlock(NodeData node, StringBuilder sb)
        {
            for (int i = 0; i < node.ChildCount; i++)
                Gen((NodeData)node.GetChild(i), sb);
        }
        public void GenVar(NodeData node, StringBuilder sb)
        {
            sb.Append("    .locals init (\n");
            GenLocalVars((NodeData)node.Parent, sb);
            if (node.Parent.Text != "function")
            {
                sb[sb.Length - 2] = ' ';
                sb.Append(")\n");
            }
        }
        public void GenBegin(NodeData node, StringBuilder sb)
        {
            sb.Append("  .method public hidebysig static void main");
            sb.Append("() cil managed {\n");
            sb.Append("    .entrypoint\n");
            sb.Append(arr);
            arr = null;
            for (int i = 0; i < node.ChildCount; i++)
                Gen((NodeData)node.GetChild(i), sb);
            sb.Append(string.Format("    L_{0:D6}: ret\n", lineNum++));
            sb.Append("  }\n}\n");
            System.IO.File.WriteAllText(@"C:\Users\Полина\Source\Repos\Compiler\MSILtry.txt", sb.ToString());
        }
        public void GenFunc(NodeData node, StringBuilder sb)
        {
            sb.Append("  .method public static");
            sb.Append(string.Format(" {0}", ToMsilType(node.GetChild(0).Text)));//возвр значение
            sb.Append(string.Format(" {0}", node.GetChild(1).Text));//имя
            GenParams(node.GetChild(2).Cast(),sb);//параметры
            sb.Append(" cil managed {\n");
            bool haveVar=false;
            curFunc = node.GetChild(0).Cast();
            StringBuilder sb0 = new StringBuilder();
            for (int i = 3; i < node.ChildCount;i++)
            {
                 if(node.GetChild(i).Text=="var" && !haveVar)
                {
                    Gen((NodeData)node.GetChild(i), sb0);
                    sb0.Append(string.Format("      [{0}] {1},\n", resNum(), ToMsilType(node.GetChild(0).Text)));
                    sb0[sb0.Length - 2] = ' ';
                    sb0.Append(")\n");
                    haveVar = true;
                }
                 else if (node.GetChild(i).Text != "var")
                     Gen((NodeData)node.GetChild(i), sb0);
            }
            if (!haveVar)
            {
                sb.Append("    .locals init (\n");
                sb.Append(string.Format("      [{0}] {1}\n", resNum(), ToMsilType(node.GetChild(0).Text)));
                sb.Append("    )\n");
            }
            sb.Append(sb0);
            sb.Append(string.Format("    L_{0:D6}: ldloc {1}\n", lineNum++,resNum()));
            sb.Append(string.Format("    L_{0:D6}: ret\n", lineNum++));
            sb.Append("  }\n");
                /*if (node.GetChild(3).Text == "var" || node.GetChild(3).Text == "const")
                {
                    Gen((NodeData)node.GetChild(3), sb);
                    resNum = node.ChildCount - 4;
                    sb.Append(string.Format("      [{0}] {1},\n", resNum, ToMsilType(node.GetChild(0).Text)));
                    sb[sb.Length - 2] = ' ';
                    sb.Append(")\n");
                    Gen((NodeData)node.GetChild(node.ChildCount - 1), sb);
                }
                else
                    Gen((NodeData)node.GetChild(3), sb);
            sb.Append(string.Format("    L_{0:D6}: ldloc {1}\n", lineNum++,node.ChildCount-4));
            sb.Append(string.Format("    L_{0:D6}: ret\n", lineNum++));
            sb.Append("  }\n");*/
            //lineNum = 0;
        }
        public void GenProc(NodeData node, StringBuilder sb)
        {
            sb.Append("  .method public static void");
            sb.Append(string.Format(" {0}", node.GetChild(0).Text));//имя
            GenParams(node.GetChild(1).Cast(), sb);//параметры
            sb.Append(" cil managed {\n");
            for (int i = 2; i < node.ChildCount; i++)
                Gen(node.GetChild(i).Cast(),sb);

            sb.Append(string.Format("    L_{0:D6}: ret\n", lineNum++));
            sb.Append("  }\n");
        }
        public void GenCall(NodeData node, StringBuilder sb)
        {
            string returnType = ToMsilType(node.GetChild(0).Cast().TypeData.ToString().ToLower());
            string funName = ToMsilType(node.GetChild(0).Text);
            StringBuilder sb0 = new StringBuilder();
            curFunc = node.GetChild(0).Cast();
            sb0.Append(string.Format("("));
            for (int i = 0; i < node.GetChild(1).ChildCount; i++)
            {
                string type = ToMsilType(node.GetChild(1).GetChild(i).Cast().TypeData.ToString().ToLower());
                if (CheckVar(node.GetChild(0).Cast(),i))
                {
                    type = ToMsilType(node.GetChild(1).GetChild(i).Cast().TypeData.ToString().ToLower()) + "&";
                    if (node.GetChild(1).GetChild(i).GetChild(0).Text.Contains("Local"))
                    {
                        sb.Append(string.Format("    L_{0:D6}: ldloca {1}\n", lineNum++, GetVarNum(node.GetChild(1).GetChild(i).Cast())));
                    }
                    else if (node.GetChild(1).GetChild(i).GetChild(0).Text.Contains("Param"))
                    {
                        sb.Append(string.Format("    L_{0:D6}: ldarga {1}\n", lineNum++, GetVarNum(node.GetChild(1).GetChild(i).Cast())));
                    }
                    else if (node.GetChild(1).GetChild(i).GetChild(0).Text.Contains("Global"))
                    {
                        sb.Append(string.Format("    L_{0:D6}: ldsflda      {1} Program::{2}\n", lineNum++, ToMsilType(node.GetChild(1).GetChild(/*node.GetChild(1).ChildCount - 1 - */i).Cast().TypeData.ToString().ToLower()), node.GetChild(1).GetChild(/*node.GetChild(1).ChildCount - 1 -*/ i).Text));
                    }
                }
                sb0.Append(string.Format("{0},", type));
                if (!CheckVar(node.GetChild(0).Cast(), i))
                {
                    if (node.GetChild(1).GetChild(i).ChildCount == 0)
                    {
                        Gen(node.GetChild(1).GetChild(i).Cast(), sb);
                    }
                    else /*if (node.GetChild(1).GetChild(i).GetChild(0).Text.Contains("Local"))
                    {
                        sb.Append(string.Format("    L_{0:D6}: ldloc {1}\n", lineNum++, GetVarNum(node.GetChild(1).GetChild(i).Cast())));
                    }
                    else if (node.GetChild(1).GetChild(i).GetChild(0).Text.Contains("Param"))
                    {
                        sb.Append(string.Format("    L_{0:D6}: ldarg {1}\n", lineNum++, GetVarNum(node.GetChild(1).GetChild(i).Cast())));
                    }
                    else if (node.GetChild(1).GetChild(i).GetChild(0).Text.Contains("Global"))
                    {
                        sb.Append(string.Format("    L_{0:D6}: ldsfld      {1} Program::{2}\n", lineNum++, ToMsilType(node.GetChild(1).GetChild(i).Cast().TypeData.ToString().ToLower()), node.GetChild(1).GetChild(i).Text));
                    }*/
                        LoadIdent(node.GetChild(1).GetChild(i).Cast(),sb);
                }
            }
            if (node.GetChild(1).ChildCount >0)
            sb0[sb0.Length - 1] = ' ';
            sb0.Append(")\n");
            sb.Append(string.Format("    L_{0:D6}: call        {1} Program::{2}", lineNum++,returnType,funName));
            sb.Append(sb0);
         }
        public void GenParams(NodeData node, StringBuilder sb)
        {
            sb.Append(string.Format(" ( "));
            for(int i=0;i<node.ChildCount;i++)
            {
                string type = node.GetChild(i).Text;
                if (type == "var")
                {
                    type = node.GetChild(i).GetChild(0).Text;
                    sb.Append(string.Format("{0}& {1},", ToMsilType(type), node.GetChild(i).GetChild(1).Text));
                }
                else
                {
                    for (int k = 0; k < node.GetChild(i).ChildCount; k++)
                    {
                        sb.Append(string.Format("{0} {1},", ToMsilType(type), node.GetChild(i).GetChild(k).Text));
                    }
                }
            }
            sb[sb.Length - 1] = ' ';
            sb.Append(")");
        }
        public void GenIdent(NodeData node, StringBuilder sb)
        {
            if (node.GetChild(0).Text.ToLower() == "index")
            {                
                LoadIdent(node,sb);
                Gen(node.GetChild(0).GetChild(0).Cast(),sb);
                sb.Append(string.Format("    L_{0:D6}: ldc.i4 {1}\n", lineNum++, 1));
                sb.Append(string.Format("    L_{0:D6}: sub\n", lineNum++));
                sb.Append(string.Format("    L_{0:D6}: ldelem.i4 \n", lineNum++));
            }
            else
            {
                 LoadIdent(node,sb);
            }
        }
        public void GenNumber(NodeData node, StringBuilder sb)
        {
            sb.Append(string.Format("    L_{0:D6}: ldc.i4 {1}\n", lineNum++, node.Text));
        }
        public void GenAssign(NodeData node, StringBuilder sb)
        {
            if (node.GetChild(0).Cast().TypeData == DataType.Char && node.ChildCount == 4)
            {
                sb.Append(string.Format("    L_{0:D6}: ldc.i4.s 0x{1}\n", lineNum++, GenCharCode(node.GetChild(2).Text)));
                StIdent(node.GetChild(0).Cast(), sb);
                return;
            }
            if (node.GetChild(0).GetChild(0).Text.ToLower() == "index")//если массив
            {
                LoadIdent(node.GetChild(0).Cast(),sb);
                Gen(node.GetChild(0).GetChild(0).GetChild(0).Cast(),sb);
                sb.Append(string.Format("    L_{0:D6}: ldc.i4 {1}\n", lineNum++, 1));
                sb.Append(string.Format("    L_{0:D6}: sub\n", lineNum++));
                Gen((NodeData)node.GetChild(1), sb);
                sb.Append(string.Format("    L_{0:D6}: stelem.i4 \n", lineNum++));
            }
            else if (node.GetChild(0).Text == "result")//если возвр значение
            {
                Gen((NodeData)node.GetChild(1), sb);
                sb.Append(string.Format("    L_{0:D6}: stloc {1}\n", lineNum++, resNum()));
            }
            else
            {
                if (node.GetChild(0).Cast().IdentDescription.Node.Text == "var" && node.GetChild(0).Cast().IdentDescription.Node.Parent.Text=="PARAMS")
                {//если передача переменной по адресу
                    Gen((NodeData)node.GetChild(0), sb);
                    Gen((NodeData)node.GetChild(1), sb);
                    sb.Append(string.Format("    L_{0:D6}: stind.i4 \n", lineNum++));
                }
                else
                {
                    Gen((NodeData)node.GetChild(1), sb);
                    if (node.GetChild(0).GetChild(0).Text.Contains("Local"))
                        sb.Append(string.Format("    L_{0:D6}: stloc {1}\n", lineNum++, GetVarNum((NodeData)node.GetChild(0))));
                    else if (node.GetChild(0).GetChild(0).Text.Contains("Param"))
                    {
                        sb.Append(string.Format("    L_{0:D6}: starg {1}\n", lineNum++, GetVarNum((NodeData)node.GetChild(0))));
                    }
                    else if (node.GetChild(0).GetChild(0).Text.Contains("Global"))
                    {
                        sb.Append(string.Format("    L_{0:D6}: stsfld      int32 Program::{1}\n", lineNum++, node.GetChild(0).Text));
                    }
                }
            }
        }
        public void GenEquals(NodeData node, StringBuilder sb)
        {
            Gen((NodeData)node.GetChild(0), sb);
            Gen((NodeData)node.GetChild(1), sb);
            sb.Append(string.Format("    L_{0:D6}: ceq\n", lineNum++));
        }
        public void GenNequals(NodeData node, StringBuilder sb)
        {
            Gen((NodeData)node.GetChild(0), sb);
            Gen((NodeData)node.GetChild(1), sb);
            sb.Append(string.Format("    L_{0:D6}: ceq\n", lineNum++));
            sb.Append(string.Format("    L_{0:D6}: not\n", lineNum++));
        }
        public void GenAdd(NodeData node, StringBuilder sb)
        {
            Gen((NodeData)node.GetChild(0), sb);
            Gen((NodeData)node.GetChild(1), sb);
            sb.Append(string.Format("    L_{0:D6}: add\n", lineNum++));
        }
        public void GenSub(NodeData node, StringBuilder sb)
        {
            Gen((NodeData)node.GetChild(0), sb);
            Gen((NodeData)node.GetChild(1), sb);
            sb.Append(string.Format("    L_{0:D6}: sub\n", lineNum++));
        }
        public void GenMul(NodeData node, StringBuilder sb)
         {
             Gen((NodeData)node.GetChild(0), sb);
             Gen((NodeData)node.GetChild(1), sb);
             sb.Append(string.Format("    L_{0:D6}: mul\n", lineNum++));
         }
        public void GenDivide(NodeData node, StringBuilder sb)
         {
             Gen((NodeData)node.GetChild(0), sb);
             Gen((NodeData)node.GetChild(1), sb);
             sb.Append(string.Format("    L_{0:D6}: div\n", lineNum++));
         }
        public void GenDiv(NodeData node, StringBuilder sb)
        {
            Gen((NodeData)node.GetChild(0), sb);
            Gen((NodeData)node.GetChild(1), sb);
            sb.Append(string.Format("    L_{0:D6}: div\n", lineNum++));
        }
        public void GenMod(NodeData node, StringBuilder sb)
        {
            Gen((NodeData)node.GetChild(0), sb);
            Gen((NodeData)node.GetChild(1), sb);
            sb.Append(string.Format("    L_{0:D6}: rem\n", lineNum++));
        }
        public void GenLess(NodeData node, StringBuilder sb)
        {
            Gen((NodeData)node.GetChild(0), sb);
            Gen((NodeData)node.GetChild(1), sb);
            sb.Append(string.Format("    L_{0:D6}: clt\n", lineNum++));
        }
        public void GenLessEquals(NodeData node, StringBuilder sb)
        {
            Gen((NodeData)node.GetChild(0), sb);
            Gen((NodeData)node.GetChild(1), sb);
            sb.Append(string.Format("    L_{0:D6}: cgt\n", lineNum++));
            sb.Append(string.Format("    L_{0:D6}: ldc.i4 {1}\n", lineNum++, 0));
            sb.Append(string.Format("    L_{0:D6}: ceq\n", lineNum++));
        }
        public void GenAnd(NodeData node, StringBuilder sb)
        {
            Gen((NodeData)node.GetChild(0), sb);
            Gen((NodeData)node.GetChild(1), sb);
            sb.Append(string.Format("    L_{0:D6}: and\n", lineNum++));
        }
        public void GenOr(NodeData node, StringBuilder sb)
       {
           Gen((NodeData)node.GetChild(0), sb);
           Gen((NodeData)node.GetChild(1), sb);
           sb.Append(string.Format("    L_{0:D6}: or\n", lineNum++));
       }
        public void GenGreater(NodeData node, StringBuilder sb)
        {
            Gen((NodeData)node.GetChild(0), sb);
            Gen((NodeData)node.GetChild(1), sb);
            sb.Append(string.Format("    L_{0:D6}: cgt\n", lineNum++));
        }
        public void GenGreaterEquals(NodeData node, StringBuilder sb)
        {
            Gen((NodeData)node.GetChild(0), sb);
            Gen((NodeData)node.GetChild(1), sb);
            sb.Append(string.Format("    L_{0:D6}: clt\n", lineNum++));
            sb.Append(string.Format("    L_{0:D6}: ldc.i4 {1}\n", lineNum++, 0));
            sb.Append(string.Format("    L_{0:D6}: ceq\n", lineNum++));
        }
        public void GenIf(NodeData node, StringBuilder sb)
        {
            StringBuilder sb0 = new StringBuilder();
            Gen((NodeData)node.GetChild(0), sb);
            int lineBr = lineNum++;
            Gen((NodeData)node.GetChild(1), sb0);
            sb.Append(string.Format("    L_{0:D6}: brfalse L_{1:D6}\n", lineBr, lineNum + 1));
            sb.Append(sb0);
            sb0 = null;
            sb0 = new StringBuilder();
            lineBr = lineNum++;
            if(node.ChildCount>2)
                Gen((NodeData)node.GetChild(2), sb0);
            sb.Append(string.Format("    L_{0:D6}: br L_{1:D6}\n", lineBr, lineNum));
            sb.Append(sb0);
            sb0 = null;
        }
        public void GenElsif(NodeData node, StringBuilder sb)
        {
            Gen((NodeData)node.GetChild(0), sb);
            int lineBr = lineNum++;
            StringBuilder sb0 = new StringBuilder();
            Gen((NodeData)node.GetChild(1), sb0);
            sb.Append(string.Format("    L_{0:D6}: brfalse L_{1:D6}\n", lineBr, lineNum + 1));
            sb.Append(sb0);
            sb0 = new StringBuilder();
            lineBr = lineNum++;
            if (node.ChildIndex + 1 < node.Parent.ChildCount)
                Gen((NodeData)node.Parent.GetChild(node.ChildIndex + 1), sb0);
            sb.Append(string.Format("    L_{0:D6}: br L_{1:D6}\n", lineBr, lineNum));
            sb.Append(sb0);
        }
        public void GenElse(NodeData node, StringBuilder sb)
        {
            StringBuilder sb0 = new StringBuilder();
            Gen((NodeData)node.GetChild(0), sb0);
            sb.Append(sb0);
        }
        public void GenFor(NodeData node, StringBuilder sb)
        {
            Gen((NodeData)node.GetChild(0), sb);

            int line1 = lineNum;
            Gen((NodeData)node.GetChild(1), sb);
            int line2 = lineNum++;
            StringBuilder sb0 = new StringBuilder();
            Gen((NodeData)node.GetChild(2), sb0);
            sb0.Append(string.Format("    L_{0:D6}: ldc.i4 {1}\n", lineNum++, 1));
            LoadIdent(node.GetChild(0).GetChild(0).Cast(),sb0);
           
              if (node.GetChild(1).Text == "LT" || node.GetChild(1).Text == "LE")
            {
                sb0.Append(string.Format("    L_{0:D6}: add\n", lineNum++));

            }
            else if (node.GetChild(1).Text == "GT" || node.GetChild(1).Text == "GE")
            {
                sb0.Append(string.Format("    L_{0:D6}: sub\n", lineNum++));
            }

            if (node.GetChild(0).GetChild(0).GetChild(0).Text.Contains("Local"))
                sb0.Append(string.Format("    L_{0:D6}: stloc {1}\n", lineNum++, GetVarNum((NodeData)node.GetChild(0).GetChild(0))));
            else if (node.GetChild(0).Text.Contains("Param"))
            {
                sb.Append(string.Format("    L_{0:D6}: starg {1}\n", lineNum++, GetVarNum((NodeData)node.GetChild(0).GetChild(0))));
            }
            else
                sb0.Append(string.Format("    L_{0:D6}: stsfld      int32 Program::{1}\n", lineNum++, (NodeData)node.GetChild(0).GetChild(0)));

            sb0.Append(string.Format("    L_{0:D6}: br L_{1:D6}\n", lineNum++, line1));
            sb.Append(string.Format("    L_{0:D6}: brfalse L_{1:D6}\n", line2, lineNum));
            sb.Append(sb0);
            sb0 = null;
        }
        public void GenWhile(NodeData node, StringBuilder sb)
        {
            int line1 = lineNum;
            Gen((NodeData)node.GetChild(0),sb);
            StringBuilder sb0 = new StringBuilder();
            Gen((NodeData)node.GetChild(1), sb0);
            int line2 = lineNum++;
            sb0.Append(string.Format("    L_{0:D6}: br L_{1:D6}\n", lineNum++, line1));
            sb.Append(string.Format("    L_{0:D6}: brfalse L_{1:D6}\n", line2, lineNum));
            sb.Append(sb0);
        }
        public void GenRepeat(NodeData node, StringBuilder sb)
        {
            int line1 = lineNum;
            Gen((NodeData)node.GetChild(1), sb);
            int line2 = lineNum++;
            StringBuilder sb0 = new StringBuilder();
            Gen((NodeData)node.GetChild(0), sb0); 
            sb0.Append(string.Format("    L_{0:D6}: br L_{1:D6}\n", lineNum++, line1));
            sb.Append(string.Format("    L_{0:D6}: brfalse L_{1:D6}\n", line2, lineNum));
            sb.Append(sb0);
        }
        public void GenPrint(NodeData node, StringBuilder sb)
        {
            Gen((NodeData)node.GetChild(0), sb);
            sb.Append(string.Format("    L_{0:D6}: call void [mscorlib]System.Console::WriteLine({1})\n", lineNum++, ToMsilType(node.GetChild(0).Cast().TypeData.ToString().ToLower())));
        }
        public void GenPrintStr(NodeData node, StringBuilder sb)
        {
            //Gen((NodeData)node.GetChild(0), sb);
            sb.Append(string.Format("    L_{0:D6}: ldstr {1}\n", lineNum++,node.GetChild(0)));
            sb.Append(string.Format("    L_{0:D6}: call void [mscorlib]System.Console::WriteLine(string)\n", lineNum++));
        }
        public bool CheckVar(NodeData node,int n)//передаю узел с параметрами
        {
            int count = 0;
            NodeData origin = node.IdentDescription.Node.Cast();
            if (origin.Text == "function")
            {
                for (int i = 0; i < origin.GetChild(2).ChildCount; i++)
                {
                    for (int k = 0; k < origin.GetChild(2).GetChild(i).ChildCount; k++)
                    {
                        if (origin.GetChild(2).GetChild(i).Text == "var" && count == n)
                            return true;
                        count++;
                    }
                }
            }
            else if (origin.Text == "procedure")
            {
                for (int i = 0; i < origin.GetChild(1).ChildCount; i++)
                {
                    for(int k=0;k<origin.GetChild(1).GetChild(i).ChildCount;k++)
                    {
                        if (origin.GetChild(1).GetChild(i).Text == "var" && count == n)
                            return true;
                        count++;
                    }
                }
            }
            return false;
        }
        public int resNum()
        {
            int res=0;
           for(int i=0;i< curFunc.Parent.ChildCount;i++)
           {
               if (curFunc.Parent.GetChild(i).Text == "var")
                   res++;
           }
           return res;
        }
        public void LoadIdent(NodeData node, StringBuilder sb)
        {
            if (node.ChildCount == 1)
            {
                if (node.GetChild(0).Text.Contains("Local"))
                {
                    sb.Append(string.Format("    L_{0:D6}: ldloc {1}\n", lineNum++, GetVarNum(node)));
                }
                else if (node.GetChild(0).Text.Contains("Param"))
                {
                    sb.Append(string.Format("    L_{0:D6}: ldarg {1}\n", lineNum++, GetVarNum(node)));
                }
                else if (node.GetChild(0).Text.Contains("Global"))
                {
                    sb.Append(string.Format("    L_{0:D6}: ldsfld     {1} Program::{2}\n", lineNum++, ToMsilType(node.TypeData.ToString().ToLower()), node.Text));
                }
            }
            else if (node.ChildCount==2)
            {

                if (node.GetChild(1).Text.Contains("Local"))
                {
                    sb.Append(string.Format("    L_{0:D6}: ldloc {1}\n", lineNum++, GetVarNum(node)));
                }
                else if (node.GetChild(1).Text.Contains("Param"))
                {
                    sb.Append(string.Format("    L_{0:D6}: ldarg {1}\n", lineNum++, GetVarNum(node)));
                }
                else if (node.GetChild(1).Text.Contains("Global"))
                {
                    sb.Append(string.Format("    L_{0:D6}: ldsfld     {1}[] Program::{2}\n", lineNum++, ToMsilType(node.TypeData.ToString().ToLower()), node.Text));
                }
            }
        }
        public void StIdent(NodeData node, StringBuilder sb)
        {
            if (node.GetChild(0).Text.Contains("Local"))
                sb.Append(string.Format("    L_{0:D6}: stloc {1}\n", lineNum++, GetVarNum(node)));
            else if (node.GetChild(0).Text.Contains("Param"))
            {
                sb.Append(string.Format("    L_{0:D6}: starg {1}\n", lineNum++, GetVarNum(node)));
            }
            else if (node.GetChild(0).Text.Contains("Global"))
            {
                sb.Append(string.Format("    L_{0:D6}: stsfld      {1} Program::{2}\n", lineNum++,ToMsilType(node.TypeData.ToString().ToLower()), node.Text));
            }
        }
        public string GenCharCode(string charText)
        {
            if (charText.Length > 1)
                throw new ApplicationException(string.Format("{0} не является символом", charText));
            return charValue.ContainsKey(Convert.ToChar(charText)) ? charValue[Convert.ToChar(charText)] : null;
        }
        public static void FullDict()
        {
            String[] readCodes = File.ReadAllLines("CharCode.txt");
            for(int i=0;i< readCodes.Length;i++)
            {
                String[] splitRead = readCodes[i].Split(' ','\t');
                charValue.Add(Convert.ToChar(splitRead[2]),splitRead[1]);
            }
        }
       
    }
}

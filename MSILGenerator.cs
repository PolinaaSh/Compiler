using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MathLang
{
    class MSILGenerator
    {

        private int lineNum = 0;
       // private StringBuilder sb0;

        public static string ToMsilType(String type)
        {
            if (type == "integer") return "int32";
            else if (type == "real") return "float32";
            else return type;
        }

        public static string Gen(NodeData program)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(@"
.assembly program
{
}
.class public auto ansi beforefieldinit Program
       extends [mscorlib]System.Object
{
");
            //.class public Program

            MSILGenerator generator = new MSILGenerator();
            generator.Gen(program, sb);
            sb.Append(@"
}
"
            );

            return sb.ToString();
        }

        private static int GetVarNum(NodeData node)
        {
            return ((InfoAboutScope)node.GetChild(0)).Ident.IndexVar;
        }

        private static void 
            GenLocalVars(NodeData node, StringBuilder sb)
        {
            if (node.Type == MathLangLexer.VAR)
            {
                string type = ToMsilType(node.GetChild(0).Text);
                int num;
                    num = GetVarNum((NodeData)node.GetChild(1));
                sb.Append(string.Format("      [{0}] {1},\n", num, type));
            }
            else
                for (int i = 0; i < node.ChildCount; i++)
                    GenLocalVars((NodeData)node.GetChild(i), sb);
        }
        private static void GenGlobalVars(NodeData node, StringBuilder sb)
        {
            if (node.Type == MathLangLexer.VAR)
            {
                string type = ToMsilType(node.GetChild(0).Text);
                    sb.Append(string.Format("  .field public static {0} {1}\n", type,node.GetChild(1).Text));
            }
            else
                for (int i = 0; i < node.ChildCount; i++)
                    GenGlobalVars((NodeData)node.GetChild(i), sb);
        }
        private static void GenGlobalConst(NodeData node, StringBuilder sb)
        {
            if (node.Type == MathLangLexer.CONST_)
            {
                string type = ToMsilType(node.GetChild(0).Text);
                int num;
                num = GetVarNum((NodeData)node.GetChild(1));
                sb.Append(string.Format("    .field public static [{0}] {1},\n", type, num));
                sb.Append(string.Format("    .method private hidebysig specialname rtspecialname static void .cctor() cil managed {.maxstack 8 \n"));
                sb.Append(String.Format("    IL_0000: ldc.i4.{0}\n ",num));
                sb.Append(String.Format("    IL_0001: stsfld int32 commands.Program::a\n }\n "));
            }
        }

        private void Gen(NodeData node, StringBuilder sb)
        {
            StringBuilder sb0;

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
                    GenAssign(node, sb);
                    break;

                case MathLangLexer.NEQUALS:
                    GenAssign(node, sb);
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
            sb[sb.Length - 2] = ' ';
            sb.Append("    )\n");
        }
        public void GenBegin(NodeData node, StringBuilder sb)
        {
            sb.Append("  .method public hidebysig static void main");
            sb.Append("() cil managed {\n");
            sb.Append("    .entrypoint\n");
            for (int i = 0; i < node.ChildCount; i++)
                Gen((NodeData)node.GetChild(i), sb);
            sb.Append(string.Format("    L_{0:D6}: ret\n", lineNum++));
            sb.Append("  }\n}\n");
            System.IO.File.WriteAllText(@"C:\Users\Полина\Source\Repos\Compiler\MSILtry.txt", sb.ToString());
        }
        public void GenFunc(NodeData node, StringBuilder sb)
        {
            sb.Append("  .method");
            for (int i = 0; i < node.GetChild(0).ChildCount; i++)
                sb.Append(string.Format(" {0}", node.GetChild(0).GetChild(i).Text));
            sb.Append(string.Format(" {0}", node.GetChild(1).Text));
            sb.Append(string.Format(" {0}", node.GetChild(2).Text));
            sb.Append("() cil managed {\n");
            if (node.GetChild(2).Text == "main")
                sb.Append("    .entrypoint\n");
            sb.Append("    .locals init (\n");
            GenLocalVars(node, sb);
            sb[sb.Length - 2] = ' ';
            sb.Append("    )\n");
            Gen((NodeData)node.GetChild(4), sb);
            sb.Append(string.Format("    L_{0:D6}: ret\n", lineNum++));
            sb.Append("  }\n");
        }
        public void GenIdent(NodeData node, StringBuilder sb)
        {
            if (node.GetChild(0).Text.Contains("Local"))
                sb.Append(string.Format("    L_{0:D6}: ldloc {1}\n", lineNum++, GetVarNum(node)));
            else if (node.GetChild(0).Text.Contains("Global"))
            {
                sb.Append(string.Format("    L_{0:D6}: ldsfld      int32 Program::{1}\n", lineNum++, node.Text/*GetVarNum(node)*/));
            }
        }
        public void GenNumber(NodeData node, StringBuilder sb)
        {
            sb.Append(string.Format("    L_{0:D6}: ldc.i4 {1}\n", lineNum++, node.Text));
        }
        public void GenAssign(NodeData node, StringBuilder sb)
        {
            Gen((NodeData)node.GetChild(1), sb);
            if (node.GetChild(0).GetChild(0).Text.Contains("Local"))
                sb.Append(string.Format("    L_{0:D6}: stloc {1}\n", lineNum++, GetVarNum((NodeData)node.GetChild(0))));
            else if (node.GetChild(0).GetChild(0).Text.Contains("Global"))
            {
                sb.Append(string.Format("    L_{0:D6}: stsfld      int32 Program::{1}\n", lineNum++, node.GetChild(0).Text/* GetVarNum(node)*/));
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

            if (node.GetChild(0).GetChild(0).GetChild(0).Text.Contains("Local"))
                sb0.Append(string.Format("    L_{0:D6}: ldloc {1}\n", lineNum++, GetVarNum((NodeData)node.GetChild(0).GetChild(0))));
            else
                sb0.Append(string.Format("    L_{0:D6}: ldsfld      int32 Program::{1}\n", lineNum++, (NodeData)node.GetChild(0).GetChild(0)));

            sb0.Append(string.Format("    L_{0:D6}: add\n", lineNum++));

            if (node.GetChild(0).GetChild(0).GetChild(0).Text.Contains("Local"))
                sb0.Append(string.Format("    L_{0:D6}: stloc {1}\n", lineNum++, GetVarNum((NodeData)node.GetChild(0).GetChild(0))));
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
            sb.Append(string.Format("    L_{0:D6}: call void [mscorlib]System.Console::WriteLine(int32)\n", lineNum++));
        }
    }
}

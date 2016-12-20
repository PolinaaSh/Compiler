using System;
using System.Globalization;
using System.IO;


using Antlr.Runtime;
using Antlr.Runtime.Tree;


namespace MathLang
{
  public class Program
  {
    // "�������������������" ������ ��� ����� (� ������������ ������)
    public static readonly NumberFormatInfo NFI = new NumberFormatInfo();

    public static MathAstNode Check(string src, Context context)
    {
        ICharStream input = new ANTLRStringStream(src);
        MathLangLexer lexer = new MathLangLexer(input);
        CommonTokenStream tokens = new CommonTokenStream(lexer);
        MathLangParser parser = new MathLangParser(tokens);
        parser.TreeAdaptor = new MathAstNodeTreeAdapter();
        MathAstNode program = (MathAstNode)parser.execute().Tree;
        for(int i=0;i<program.ChildCount;i++)
        SemanticChecker.Check((MathAstNode)program.GetChild(i), context);
        return program;
    }

    public static void Main(string[] args) {
      try {
        // � ����������� �� ������� ���������� ��������� ������ ���������
        // ���� ���� � ������, ���������� ������ ����������, ���� ����������� ����
          Context context = new Context(null);
         /* string src = @"
            function IntSqrt(a:integer):integer;;
            procedure PrintInt(a: integer);
            procedure PrintReal(a:real)
        ";
          Check(src, context);*/
        ICharStream input = args.Length == 1 ? (ICharStream)new ANTLRFileStream(args[0])
                                             : (ICharStream)new ANTLRReaderStream(Console.In);
        MathLangLexer lexer = new MathLangLexer(input);
        CommonTokenStream tokens = new CommonTokenStream(lexer);
        MathLangParser parser = new MathLangParser(tokens);
        parser.TreeAdaptor= new MathAstNodeTreeAdapter();
        ITree program = (ITree)parser.execute().Tree;
        AstNodePrinter.Print(program);
        Console.WriteLine();
        //MathLangIntepreter.Execute(program);
        SemanticChecker.Check((MathAstNode)program, context);
        Console.ReadLine();
        AstNodePrinter.Print(program);
        }
      catch (Exception e) {
        Console.WriteLine("Error: {0}", e);
      }
      Console.ReadKey();
    }
  }
}

using System.Collections.Generic;

using Antlr.Runtime;
using Antlr.Runtime.Tree;


namespace MathLang
{
  public class MathAstNode: CommonTree
  {
      private string text;
      public bool check { get; set; }
      public DataType DataType { get; set; }
      public override string Text
      {
          get
          {
              if (this.text == null)
                  return base.Text;
              else
              return this.text;
          }
          set
          {
              this.text = value;
              base.Text = value;
          }
      }

    public MathAstNode()
      : base() {
    }

    public MathAstNode(IToken t)
      : base(t) {
    }

    public MathAstNode(CommonTree node)
      : base(node) {
    }

   /*public override ITree DupNode()
    {
        return new MathAstNode();
    }*/
  }
  public class MathAstNodeTreeAdapter : CommonTreeAdaptor
  {
      public override object Create(IToken payload)
      {
          return new MathAstNode(payload);
      }
  }
}

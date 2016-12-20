using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace MathLang
{
    public class TreeAdapterSSKA : CommonTreeAdaptor
    {
        public override object Create(IToken payload)
        {
            return new NodeData(payload);
        }
    }
}
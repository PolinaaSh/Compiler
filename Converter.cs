using Antlr.Runtime.Tree;

namespace MathLang
{
    public static class Converter
    {
        public static NodeData Cast(this ITree tree)
        {
             return (NodeData)tree;
        }
        public static DataType TypeData(this ITree tree)
        {
            return ((NodeData)tree).TypeData;
        }
    }
}
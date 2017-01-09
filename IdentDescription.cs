using Antlr.Runtime.Tree;

namespace MathLang
{
    public enum IdentType
    {
        Global,
        Local,
        Param,
        Function,
        Procedure
    }
    public enum DataType
    {
        Void,
        Integer,
        Real,
        Boolean,
        Char
    }

    public class IdentDescription
    {
        private string nameAttribut;
        private IdentType typeIdent;
        private DataType dataType;
        private bool isArray;
        private bool isConst;
        private ITree node;
        private int indexVar;// для глобальных своя для лок своя, для парам своя. для локальных если встречается дважды кинуть в разные.

        public IdentDescription(ITree node, DataType dataType, IdentType typeIdent, bool isArray, bool isConst)
        {
            this.node = node;
            this.isArray = isArray;
            this.isConst = isConst;
            this.dataType = dataType;
            this.typeIdent = typeIdent;
        }

        public IdentType TypeIdent
        {
            get { return typeIdent; }
            set { typeIdent = value; }
        }
        public string NameAttribut
        {
            get { return nameAttribut; }
            set { nameAttribut = value; }
        }
        public bool IsArray
        {
            get { return isArray; }
        }

        public bool IsConst
        {
            get { return isConst; }
        }

        public ITree Node
        {
            get { return node; }
        }
        public DataType TypeData
        {
            get { return dataType; }
            set { dataType = value; }
        }
        public int IndexVar
        {
            get { return indexVar; }
            set { indexVar = value; }
        }
    }
}
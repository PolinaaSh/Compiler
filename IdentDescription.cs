﻿using Antlr.Runtime.Tree;

namespace MathLang
{
    public enum IdentType
    {
        Global,
        Local,
        Param,
        Function
    }
    public enum DataType
    {
        Void,
        Int,
        Float,
        Bool
    }

    public class IdentDescription
    {
        private string nameAttribut;
        private IdentType typeIdent;
        private DataType dataType;
        private bool isArray;
        private ITree node;
        private int indexVar;// для глобальных своя для лок своя, для парам своя. для локальных если встречается дважды кинуть в разные.

        public IdentDescription(ITree node, DataType dataType, IdentType typeIdent, bool isArray)
        {
            this.node = node;
            this.isArray = isArray;
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
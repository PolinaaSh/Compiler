using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace MathLang
{
    public class NodeData : CommonTree
    {
        private DataType dataType;
        public bool check;

        public NodeData()
            : base()
        {
        }

        public NodeData(IToken t)
            : base(t)
        {
        }

        public NodeData(CommonTree node)
            : base(node)
        {
        }

        public override ITree DupNode()
        {
            return new NodeData(this);
        }

        public DataType TypeData
        {
            get { return dataType; }
            set { dataType = value; }
        }

        public IdentDescription IdentDescription
        {
            get;
            set;
        }
    }
}
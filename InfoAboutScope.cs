using System;
using System.Collections.Generic;
using Antlr.Runtime;
using Antlr.Runtime.Tree;

namespace MathLang
{
    public class InfoAboutScope : NodeData
    {
        private Scope localScope;
        private IdentDescription ident;

        public InfoAboutScope()
            : base()
        {
        }
        public InfoAboutScope(IToken t)
            : base(t)
        {
        }
        public InfoAboutScope(CommonTree node)
            : base(node)
        {
        }

        public Scope LocalScope
        {
            get { return localScope; }
            set { localScope = value; }
        }
        public IdentDescription Ident
        {
            get { return ident; }
            set { ident = value; }
        }
    }
}
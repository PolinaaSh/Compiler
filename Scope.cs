using System;
using System.Collections.Generic;

namespace MathLang
{
    public enum TypeScope
    {
        Non, Global, Local
    }
    public class Scope
    {
        private Scope parent;
        private Dictionary<string, IdentDescription> dicIdents;
        private IdentDescription function;
        private TypeScope typeScope;
        private int indexatorLocal;
        private int indexatorGlobal;
        private int indexatorParam;

        public Scope(TypeScope typeScope, Scope parent = null)
        {
            this.typeScope = typeScope;
            this.parent = parent;
            dicIdents = new Dictionary<string, IdentDescription>();
        }
        public void RegisterIdent(string name, IdentDescription disc)
        {
            dicIdents.Add(name, disc);
            disc.NameAttribut = name;
            disc.IndexVar = GetFreeIndexVar(disc.TypeIdent);
        }
        public IdentDescription GetContainVar(string name)
        {
            return dicIdents.ContainsKey(name) ? dicIdents[name] : null;
        }
        public IdentDescription GetContainVarRecursive(string name)
        {
            IdentDescription isContain = GetContainVar(name);
            if (isContain == null && parent != null)
                isContain = parent.GetContainVarRecursive(name);
            return isContain;
        }
        public int GetFreeIndexVar(IdentType identType)
        {
            int result = 0;
            switch (identType)
            {
                case IdentType.Global:
                    result = GetIndexGlobal();
                    break;
                case IdentType.Local:
                    result = GetIndexLocal();
                    break;
                case IdentType.Param:
                    result = GetIndexParam();
                    break;
                case IdentType.Function:
                    result = GetIndexGlobal();
                    break;
                default:
                    throw new ApplicationException("Out of range");
            }
            return result;
        }
        public int GetIndexGlobal()
        {
            return typeScope == TypeScope.Global ? indexatorGlobal++ : parent.GetIndexGlobal();
        }
        public int GetIndexLocal()
        {
            return typeScope == TypeScope.Local ? indexatorLocal++ : parent.GetIndexLocal();
        }
        public int GetIndexParam()
        {
            return typeScope == TypeScope.Local ? indexatorParam++ : parent.GetIndexParam();
        }
        public IdentDescription Function
        {
            get
            {
                if (function == null)
                    return parent.function;
                else
                    return function;
            }
            set { function = value; }
        }
    }
}
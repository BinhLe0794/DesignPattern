using System;
namespace ProxyDesignPattern
{
    public class Core : ACore
    {
        private string _nameCore;

        public Core(string nameCore)
        {
            _nameCore = nameCore;
        }

        public override string GetName()
        {
            return _nameCore;
        }
    }
}


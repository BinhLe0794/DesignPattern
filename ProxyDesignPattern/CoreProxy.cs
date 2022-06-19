using System;
namespace ProxyDesignPattern
{
    public class CoreProxy : ACore
    {
        bool _isAdmin = false;
        private Core core;


        public CoreProxy(bool isAdmin = false)
        {
            _isAdmin = isAdmin;
        }

        public override string GetName()
        {
            if (_isAdmin)
            {
                core = new Core("Admin Core");
                return core.GetName();
            }
            core = new Core("User Core");
            return core.GetName();
        }

    }
}


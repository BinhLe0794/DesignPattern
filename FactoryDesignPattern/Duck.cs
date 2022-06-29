using FactoryDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    internal class Duck : IAnimal
    {
        public string GetName()
        {
            return "Duck";
        }
    }
}

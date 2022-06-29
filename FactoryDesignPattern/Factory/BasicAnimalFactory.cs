using FactoryDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Factory
{
    internal class BasicAnimalFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal()
        {
            throw new NotImplementedException();
        }
    }
}

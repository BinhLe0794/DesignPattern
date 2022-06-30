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
        public int Index { get; set; } = 0;
        public IAnimal CreateAnimal()
        {
            if (Index == 0)
            {
                Index++;
                return new Dog();
            }else if(Index == 1)
            {
                Index++;
                return new Cat();
            }
            else
            {
                Index = 0;
                return new Duck();
            }
        }
    }
}

using FactoryDesignPattern.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern.Factory
{
    internal class RandomAnimalFactory : IAnimalFactory
    {
        public int Index { get; set; }
        public IAnimal CreateAnimal()
        {
            var random = new Random();
            Index = random.Next(0, 2);
            if (Index == 0)
            {
                return new Dog();
            }
            else if (Index == 1)
            {
                return new Cat();
            }
            else
            {
                return new Duck();
            }
        }
    }
}

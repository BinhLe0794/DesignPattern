using FactoryDesignPattern.Factory;
using FactoryDesignPattern.Interface;

namespace FactoryDesignPattern
{
    internal class Program
    {
        /* Factory Design Pattern
         * Được sử dụng để tạo ra một obj khi dựa vào interface với 1 số điều kiện cụ thể.
         * 
         */

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            IAnimalFactory factory;

            Random random = new();

            int type = random.Next(0,2);

            if (type == 0)
            {
                factory = new BasicAnimalFactory();
            }
            else
            {
                factory = new RandomAnimalFactory();
            }
            var animal = factory.CreateAnimal();
            Console.WriteLine(animal.ToString());
            Console.ReadLine();
        }
    }
}
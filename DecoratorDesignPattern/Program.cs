using DecoratorDesignPattern;
using DecoratorDesignPattern.Coffee;
using DecoratorDesignPattern.Coffee.Decorator;
using DecoratorDesignPattern.MilkTea;
using DecoratorDesignPattern.MilkTea.Decorators;

Console.WriteLine("This is Decorator Design Pattern");
// var orderMilkTea =
//    new EggPudding(
//       new FruitPudding(
//          new Bubble(
//             new MilkTea()
//          )));
// Console.WriteLine("Cost: " + orderMilkTea.Cost());
var milkCoffee = new MilkCoffee(new CoffeeBase());

Console.WriteLine("milkCoffee: " + milkCoffee.GetPrice());
Console.Read();
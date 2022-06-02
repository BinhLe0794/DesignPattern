
using DecoratorDesignPattern;
using DecoratorDesignPattern.Decorators;

Console.WriteLine("This is Decorator Design Pattern");

var orderMilkTea =
    new EggPudding(
        new FruitPudding(
            new Bubble(
                new MilkTea()
                )));
Console.WriteLine("Cost: " + orderMilkTea.Cost());
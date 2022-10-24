namespace DecoratorDesignPattern.Coffee.Decorator;

public class MilkCoffee : CoffeeDecorator
{
  private readonly ICoffee _coffeeBase;
  public MilkCoffee(ICoffee coffeeBase) : base(coffeeBase)
  {
    _coffeeBase = coffeeBase;
  }

  public override int GetPrice()
  {
    return base.GetPrice() + 5;
  }
}
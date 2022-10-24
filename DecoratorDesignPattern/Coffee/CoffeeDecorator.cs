namespace DecoratorDesignPattern.Coffee;

public abstract class CoffeeDecorator: ICoffee // abstract -> không khởi tạo object từ thằng decorator base
{
  private readonly ICoffee _coffeeBase;

  protected CoffeeDecorator(ICoffee coffeeBase) // inject những sub_class decorator : ICoffee
  {
    _coffeeBase = coffeeBase;
  }

  public virtual int GetPrice()
  {
    return _coffeeBase.GetPrice();
  }
}
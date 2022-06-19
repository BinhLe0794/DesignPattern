using DecoratorDesignPattern.Base;

namespace DecoratorDesignPattern.Decorators;
public class FruitPudding : MilkTeaDecorator
{
   public FruitPudding(IMilkTea innermilkTea) : base(innermilkTea)
   {
   }
   public override double Cost()
   {
      return 2d + base.Cost();
   }
}
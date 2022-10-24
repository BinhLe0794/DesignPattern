using DecoratorDesignPattern.MilkTea.Base;

namespace DecoratorDesignPattern.MilkTea.Decorators;
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
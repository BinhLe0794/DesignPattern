using DecoratorDesignPattern.MilkTea.Base;

namespace DecoratorDesignPattern.MilkTea.Decorators;
public class Bubble : MilkTeaDecorator
{
   public Bubble(IMilkTea innermilkTea) : base(innermilkTea)
   {
   }
   // override lai tu astrast class
   public override double Cost()
   {
      return 1d + base.Cost();
   }
}
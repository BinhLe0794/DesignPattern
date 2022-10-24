using DecoratorDesignPattern.MilkTea.Base;

namespace DecoratorDesignPattern.MilkTea.Decorators;
public class BlackSugar : MilkTeaDecorator
{
   public BlackSugar(IMilkTea innermilkTea) : base(innermilkTea)
   {
   }
   public override double Cost()
   {
      return 2d + base.Cost();
   }
}
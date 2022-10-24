using DecoratorDesignPattern.MilkTea.Base;

namespace DecoratorDesignPattern.MilkTea;
public class MilkTea : IMilkTea
{
   public double Cost()
   {
      return 5d;
   }
}
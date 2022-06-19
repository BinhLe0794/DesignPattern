using DecoratorDesignPattern.Base;

namespace DecoratorDesignPattern;
public class MilkTea : IMilkTea
{
   public double Cost()
   {
      return 5d;
   }
}
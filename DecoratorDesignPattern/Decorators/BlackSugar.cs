using System;
using DecoratorDesignPattern.Base;

namespace DecoratorDesignPattern.Decorators
{
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
}


using System;
using DecoratorDesignPattern.Base;

namespace DecoratorDesignPattern.Decorators
{
    public class EggPudding : MilkTeaDecorator
    {
        public EggPudding(IMilkTea innermilkTea) : base(innermilkTea)
        {
        }

        public override double Cost()
        {
            return 3d + base.Cost();
        }
    }
}


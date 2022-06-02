using System;
namespace DecoratorDesignPattern.Base
{
    public abstract class MilkTeaDecorator : IMilkTea
    {
        private IMilkTea _milkTea;
        protected MilkTeaDecorator(IMilkTea innermilkTea)
        {
            _milkTea = innermilkTea;
        }
        // de virtual de cac class ke thua co the override
        public virtual double Cost()
        {
            return _milkTea.Cost();
        }
    }
}


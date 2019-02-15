using SuperMarketPricing.Interfaces;
using System;

namespace SuperMarketPricing
{
    /// <summary>
    /// Buy X Get One pricing strategy.
    /// </summary>
    public abstract class BuyXGetOneStrategy : IPricingStrategy
    {
        public abstract Sku Sku { get; }
        protected abstract double Price { get; }

        private int _xToBuy;

        /// <param name="xToBuy">Number of items that must be purchased to get the discount.</param>
        public BuyXGetOneStrategy(int xToBuy)
        {
            if (xToBuy < 2)
            {
                throw new ArgumentOutOfRangeException(nameof(xToBuy), xToBuy, "Cannot be less than two.");
            }

            _xToBuy = xToBuy;
        }

        public double GetPrice(int count)
        {
            if (count < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(count), count, "Cannot be less than zero.");
            }

            double result = 0;

            while (count - _xToBuy >= 0) 
            {
                result = result + Price*2;
                count = count - _xToBuy;
            }
            if (count == 2)
            {
                result = result + Price;
            }
            if (count > 0)
            {
                result = result + Price;
            }

            return result;
        }
    }
}

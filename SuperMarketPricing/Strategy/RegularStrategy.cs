using SuperMarketPricing.Interfaces;

namespace SuperMarketPricing
{
    public abstract class RegularStrategy : IPricingStrategy
    {
        public abstract Sku Sku { get; }
        protected abstract double Price { get; }

        public double GetPrice(int count)
        {
            return Price * count;
        }
    }
}

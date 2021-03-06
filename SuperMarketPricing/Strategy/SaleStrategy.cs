﻿using SuperMarketPricing.Interfaces;

namespace SuperMarketPricing
{
    /// <summary>
    /// Sale Pricing Strategy.
    /// </summary>
    public abstract class SaleStrategy : IPricingStrategy
    {
        public abstract Sku Sku { get; }
        protected abstract double PricePerOne { get; }
        protected abstract double PricePerX { get; }
        protected abstract int X { get; }

        public double GetPrice(int count)
        {
            if (count == 0)
            {
                return 0;
            }

            double result = 0;

            while (count >= X)
            {
                result = result + PricePerX;
                count = count - X;
            }

            return result + (PricePerOne * count);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketPricing
{
    public class PricingProductA : SaleStrategy
    {
        public override Sku Sku { get; } = 'A';
        protected override double PricePerOne { get; } = 50;
        protected override double PricePerX { get; } = 130;
        protected override int X { get; } = 3;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketPricing
{
    public class PricingProductC:RegularStrategy
    {
        public override Sku Sku { get; } = 'C';
        protected override double Price { get; } = 20;
    }
}

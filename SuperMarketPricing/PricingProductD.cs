using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketPricing
{
    public class PricingProductD : RegularStrategy
    {
        public override Sku Sku { get; } = 'D';
        protected override double Price { get; } = 15;
    }
}

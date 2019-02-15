using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperMarketPricing.Interfaces
{
    public interface IPricingStrategy
    {
        Sku Sku { get; }
        double GetPrice(int count);
    }
}

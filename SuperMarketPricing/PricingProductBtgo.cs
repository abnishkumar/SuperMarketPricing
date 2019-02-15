namespace SuperMarketPricing
{
    /// <summary>
    /// Buy Two Get One pricing strategy.
    /// </summary>
    public class PricingProductBtgo : BuyXGetOneStrategy
    {
        public override Sku Sku { get; } = 'E';
        protected override double Price { get; } = 50;
        public PricingProductBtgo() : base(3)
        { }
    }
}

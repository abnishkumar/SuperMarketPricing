using Microsoft.VisualStudio.TestTools.UnitTesting;
using SuperMarketPricing.Interfaces;
using System.Collections.Generic;

namespace SuperMarketPricing.Tests
{
    [TestClass]
    public class ShoppingCartTests
    {
        [TestMethod]
        public void Cart_WhenNoProducts_PriceIsZero()
        {
            var cart = new ShoppingCart(GetPricingStrategies());
            var products = new List<Sku>();

            var price = cart.Checkout(products);

            Assert.AreEqual(0, price);
        }

        [TestMethod]
        public void Cart_OneA_Is50()
        {
            var cart = new ShoppingCart(GetPricingStrategies());
            var products = new List<Sku>() { 'A' };

            var price = cart.Checkout(products);

            Assert.AreEqual(50, price);
        }

        [TestMethod]
        public void Cart_TwoA_Is100()
        {
            var cart = new ShoppingCart(GetPricingStrategies());
            var products = new List<Sku>() { 'A', 'A' };

            var price = cart.Checkout(products);

            Assert.AreEqual(100, price);
        }

        [TestMethod]
        public void Cart_ThreeA_Is130()
        {
            var cart = new ShoppingCart(GetPricingStrategies());
            var products = new List<Sku>() { 'A', 'A', 'A' };

            var price = cart.Checkout(products);

            Assert.AreEqual(130, price);
        }

        [TestMethod]
        public void Cart_FourA_Is180()
        {
            var cart = new ShoppingCart(GetPricingStrategies());
            var products = new List<Sku>() { 'A', 'A', 'A', 'A' };

            var price = cart.Checkout(products);

            Assert.AreEqual(180, price);
        }

        [TestMethod]
        public void Cart_SixA_Is260()
        {
            var cart = new ShoppingCart(GetPricingStrategies());
            var products = new List<Sku>() { 'A', 'A', 'A', 'A', 'A', 'A' };

            var price = cart.Checkout(products);

            Assert.AreEqual(260, price);
        }

        [TestMethod]
        public void Cart_OneB_Is30()
        {
            var cart = new ShoppingCart(GetPricingStrategies());
            var products = new List<Sku>() { 'B' };

            var price = cart.Checkout(products);

            Assert.AreEqual(30, price);
        }

        [TestMethod]
        public void Cart_TwoBIs45()
        {
            var cart = new ShoppingCart(GetPricingStrategies());
            var products = new List<Sku>() { 'B', 'B' };

            var price = cart.Checkout(products);

            Assert.AreEqual(45, price);
        }

        [TestMethod]
        public void Cart_ThreeBIs75()
        {
            var cart = new ShoppingCart(GetPricingStrategies());
            var products = new List<Sku>() { 'B', 'B', 'B' };

            var price = cart.Checkout(products);

            Assert.AreEqual(75, price);
        }

        public void Cart_FourBIs90()
        {
            var cart = new ShoppingCart(GetPricingStrategies());
            var products = new List<Sku>() { 'B', 'B', 'B', 'B' };

            var price = cart.Checkout(products);

            Assert.AreEqual(90, price);
        }

        [TestMethod]
        public void Cart_OneAOneB_Is80()
        {
            var cart = new ShoppingCart(GetPricingStrategies());
            var products = new List<Sku>() { 'A', 'B' };

            var price = cart.Checkout(products);

            Assert.AreEqual(80, price);
        }

        [TestMethod]
        public void Cart_OneATwoB_OutOfOrder_Is95()
        {
            var cart = new ShoppingCart(GetPricingStrategies());
            var products = new List<Sku>() { 'B', 'A', 'B' };

            var price = cart.Checkout(products);

            Assert.AreEqual(95, price);
        }

        [TestMethod]
        public void Cart_OneC_Is20()
        {
            var cart = new ShoppingCart(GetPricingStrategies());
            var products = new List<Sku>() { 'C' };

            var price = cart.Checkout(products);

            Assert.AreEqual(20, price);
        }

        [TestMethod]
        public void Cart_TwoC_Is20()
        {
            var cart = new ShoppingCart(GetPricingStrategies());
            var products = new List<Sku>() { 'C', 'C' };

            var price = cart.Checkout(products);

            Assert.AreEqual(40, price);
        }

        [TestMethod]
        public void Cart_OneD_Is15()
        {
            var cart = new ShoppingCart(GetPricingStrategies());
            var products = new List<Sku>() { 'D' };

            var price = cart.Checkout(products);

            Assert.AreEqual(15, price);
        }

        [TestMethod]
        public void Cart_TwoD_Is30()
        {
            var cart = new ShoppingCart(GetPricingStrategies());
            var products = new List<Sku>() { 'D', 'D' };

            var price = cart.Checkout(products);

            Assert.AreEqual(30, price);
        }


        [TestMethod]
        public void Cart_ByeOne_NoDiscount_Is50()
        {
            var cart = new ShoppingCart(GetPricingStrategies());
            var products = new List<Sku>() { 'E' };
            var price = cart.Checkout(products);
            // here buy 1 ,so price will be 50
            Assert.AreEqual(50, price);
        }
       

        [TestMethod]
        public void Cart_BuyThreeE_GetOneEFree_Is100()
        {
            var cart = new ShoppingCart(GetPricingStrategies());
            var products = new List<Sku>() { 'E', 'E', 'E' };
            var price = cart.Checkout(products);
            // 3*50=150
            // here buy 2 get one rule applied
            // price will be 100
            Assert.AreEqual(100, price);
        }

        [TestMethod]
        public void Cart_BuyFourE_GetOneEFree_Is150()
        {
            var cart = new ShoppingCart(GetPricingStrategies());
            var products = new List<Sku>() { 'E', 'E', 'E', 'E' };
            var price = cart.Checkout(products);
            // here buy 2 get one rule applied
            // price will be 150
            Assert.AreEqual(150, price);
        }
        [TestMethod]
        public void Cart_BuySixE_Get2EFree_Is200()
        {
            var cart = new ShoppingCart(GetPricingStrategies());
            var products = new List<Sku>() { 'E', 'E', 'E', 'E', 'E', 'E' };

            var price = cart.Checkout(products);
            // 6 product price 50*6=300
            // here buy 2 get one rule applied
            // price will be 200
            Assert.AreEqual(200, price);
        }

        private static List<IPricingStrategy> GetPricingStrategies()
        {
            return new List<IPricingStrategy>()
            {
                new PricingProductA(),
                new PricingProductB(),
                new PricingProductC(),
                new PricingProductD(),
                new PricingProductBtgo()
            };
        }
    }
}

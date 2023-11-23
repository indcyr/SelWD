using BunnyCart.PageObjects;
using BunnyCart.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunnyCart.TestScripts
{
    [TestFixture]
    internal class SearchTest : CoreCodes
    {
        [Test]
        [TestCase("Water")]

        public void SearchProductandAddToCartTest(string searchtext)
        {
            BCHP bchp = new(driver);
            var searchrespage = bchp?.TypeSearchInput(searchtext);
            Assert.That(searchtext.Contains(searchrespage?.GetFirstProductLink()));
            var productpage = searchrespage?.ClickFirstProductLink();
            Assert.That(searchrespage.Equals(productpage?.GetProductTitleLabel()));
            productpage?.ClickInQtyLink();
            productpage?.ClickAddToCartBtn();
            //Assert
            Thread.Sleep(1000);
        }
    }
}

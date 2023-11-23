using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsTest.PageObjects
{
    internal class ProductList
    {
        IWebDriver driver;

        public ProductList(IWebDriver? driver)
        {
            this.driver = driver ?? throw new ArgumentException(nameof(driver));
            PageFactory.InitElements(driver, this);
        }
        //Arrange
        [FindsBy(How = How.Id, Using = "productItem5")]
        public IWebElement? ProductSelection { get; set; }


        public AddToCart ClickProduct()
        {

            ProductSelection?.Click();
            return new AddToCart(driver);
        }
    }
}

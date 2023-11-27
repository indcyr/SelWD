using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace CaseStudy.PageObjects
{
    internal class NaptolHomePage
    {
        IWebDriver driver;
        public NaptolHomePage(IWebDriver? driver)
        {
            this.driver = driver ?? throw new ArgumentException(nameof(driver));//if the driver is null exception thrown
            PageFactory.InitElements(driver, this);
        }

        //Arrange
        [FindsBy(How = How.XPath, Using = "//input[@id='header_search_text']")]
        public IWebElement? SearchText { get; set; }

        //Act
        public ProductList TypeSearch(string searchTerm)
        {
            SearchText?.SendKeys(searchTerm);
            SearchText?.SendKeys(Keys.Enter);
            return new ProductList(driver);
        }
    }
}
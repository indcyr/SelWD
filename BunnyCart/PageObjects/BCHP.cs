using BunnyCart.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V117.DOM;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunnyCart.PageObjects
{
    internal class BCHP 
    {
        IWebDriver driver;
        public BCHP(IWebDriver? driver)
        {
            this.driver = driver ?? throw new ArgumentNullException(nameof(driver));
            PageFactory.InitElements(driver, this);
        }
        //Arrange

       
        //private IWebElement CreateAccountLink {  get; set; }

        [FindsBy(How = How.Id, Using = "search")]
        [CacheLookup]
        private IWebElement? SearchInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[text()='Create an Account']")]
        [CacheLookup]
        public IWebElement? CreateAnAcct { get; set; }

        [FindsBy(How = How.Id, Using = "firstname")]
        [CacheLookup]
        private IWebElement? FirstNameInput { get; set; }

        [FindsBy(How = How.Id, Using = "lastname")]
        [CacheLookup]
        private IWebElement? LastNameInput { get; set; }

        [FindsBy(How = How.Name, Using = "email")]
        [CacheLookup]
        private IWebElement? Email { get; set; }

        [FindsBy(How = How.Id, Using = "password")]
        [CacheLookup]
        private IWebElement? PasswordInput { get; set; }

        [FindsBy(How = How.Name, Using = "password_confirmation")]
        [CacheLookup]
        private IWebElement? ConfirmPasswordInput { get; set; }

        [FindsBy(How = How.Id, Using = "mobilenumber")]
        [CacheLookup]
        private IWebElement? MobileNumberInput { get; set; }

        [FindsBy(How = How.XPath, Using = "//button[@title='Create an Account']")]
        [CacheLookup]
        private IWebElement? SignUpButton { get; set; }

        //Act
        public void ClickCreateAnAccountLink()
        {
            CreateAnAcct?.Click();
        }

        public void SignUp(string firstname, string lastname, string email, string pwd, string conpwd, string mbno)
        {
            IWebElement modal = new WebDriverWait(driver, TimeSpan.FromSeconds(30))
                .Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(
                By.XPath("(//div[@class='modal-inner-wrap])[position()=2]")));

            FirstNameInput?.SendKeys(firstname);
            LastNameInput?.SendKeys(lastname);
            Email?.SendKeys(email);

            CoreCodes.ScrollIntoView(driver, modal.FindElement(By.Id("password")));
            PasswordInput?.SendKeys(pwd);
            ConfirmPasswordInput?.SendKeys(conpwd);

            CoreCodes.ScrollIntoView(driver, modal.FindElement(By.Id("mobilenumber")));
            MobileNumberInput?.SendKeys(mbno);
            Thread.Sleep(1000);
            SignUpButton?.Click();
        }
       
        public SearchResultsPage TypeSearchInput(string searchtext)
        {
            if(SearchInput == null)
            {
                throw new NoSuchElementException(nameof(SearchInput));
            }
            SearchInput?.SendKeys(searchtext);
            SearchInput?.SendKeys(Keys.Enter);
            return new SearchResultsPage(driver);
        }
        //static void ScrollIntoView(IWebDriver driver, IWebElement element)
        //{
        //    IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
        //    js.ExecuteScript("arguments[0].ScrollIntoView(true);", element);
        //}
    }
}

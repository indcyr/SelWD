using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rediff.PageObjects
{
    internal class CreateAccountPage
    {
        IWebDriver? driver = null;
        public CreateAccountPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        //Arrange
        [FindsBy(How = How.XPath, Using ="//input[contains(@name,'name')]")]
        public IWebElement? FullNameText { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'login')]")]
        public IWebElement? RediffmailText { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@name,'btnchkavail')]")]
        public IWebElement? CheckAvailablilityBtn { get; set; }


        [FindsBy(How = How.Id, Using = "Register")]
        public IWebElement? CreateYAcctBtn { get; set; }

        //Act
        public void FullNameType(String fullname)
        {
            FullNameText?.SendKeys(fullname);
        }
        public void RediffmailType(String email)
        {
            FullNameText?.SendKeys(email);
        }
        public void CheckAvailabilityBtnClick()
        {
            CheckAvailablilityBtn?.Click();
        }
        public void FullNameClear()
        {
            FullNameText?.Clear();
        }
        public void RediffmailClear()
        {
            RediffmailText?.Clear();
        }
        public void CreateMyAcctBtnClick()
        {
            CreateYAcctBtn?.Click();
        }
        //public void CreateAccountLinkClick()
        //{
        //    CreateAccountLink?.Click();
        //}
        //public void SignInLinkClick()
        //{
        //    SignInLink?.Click();
        //}


    }
}

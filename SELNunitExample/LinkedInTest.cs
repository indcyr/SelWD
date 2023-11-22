using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V117.Runtime;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SELNunitExample
{
    [TestFixture]
    internal class LinkedInTest : CoreCodes
    {
        [Test,Author("Indu","indcyr@gmail.com")]
        [Description("Check for Valid Login")]
        [Category("Regression Testing")]
        public void LoginTest()
        {

            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
            //IWebElement emailInput = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("session_key")));
            //IWebElement passwordInput = wait.Until(ExpectedConditions.ElementIsVisible(By.Id("session_password")));

            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element Not Found";

            //IWebElement emailInput = wait.Until(driv => driv.FindElement(By.Id("session_key")));
            //IWebElement passwordInput = wait.Until(driv => driv.FindElement(By.Id("session_password")));

            IWebElement emailInput = fluentWait.Until(driv => driv.FindElement(By.Id("session_key")));
            IWebElement passwordInput = fluentWait.Until(driv => driv.FindElement(By.Id("session_password")));

            emailInput.SendKeys("abc@xyz.com");
            passwordInput.SendKeys("12345");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        /*
        [Test, Author("Indu", "indcyr@gmail.com")]
        [Description("Check for InValid Login")]
        [Category("Smoke Testing")]
        public void LoginTestWithInvalidCred()
        {
           

            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element Not Found";

           

            IWebElement emailInput = fluentWait.Until(driv => driv.FindElement(By.Id("session_key")));
            IWebElement passwordInput = fluentWait.Until(driv => driv.FindElement(By.Id("session_password")));

            emailInput.SendKeys("abc@xyz.com");
            passwordInput.SendKeys("12345");
            Thread.Sleep(3000);
            ClearForm(emailInput);
            ClearForm(passwordInput);


            emailInput.SendKeys("ghjc@xyz.com");
            passwordInput.SendKeys("1655");
            Thread.Sleep(3000);
            ClearForm(emailInput);
            ClearForm(passwordInput);

            emailInput.SendKeys("ghgyj@xyz.com");
            passwordInput.SendKeys("5675");
            Thread.Sleep(3000);
            ClearForm(emailInput);
            ClearForm(passwordInput);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }
        */

        [Test,Author("AAA", "AAA@gmail.com")]
        [Description("Check for InValid Login"),Category("Regression Testing")]
        [TestCaseSource(nameof(InvalidLoginData))]
        public void LoginTestWithInValidCred(string email, string pwd)
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Element Not Found";



            IWebElement emailInput = fluentWait.Until(driv => driv.FindElement(By.Id("session_key")));
            IWebElement passwordInput = fluentWait.Until(driv => driv.FindElement(By.Id("session_password")));

            emailInput.SendKeys(email);
            passwordInput.SendKeys(pwd);
            TakeScreenShot();

            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", 
                driver.FindElement(By.XPath("//button[@type='submit']")));
            js.ExecuteScript("arguments[0].click();", 
                driver.FindElement(By.XPath("//button[@type='submit']")));
            Thread.Sleep(5000);

            ClearForm(emailInput);
            ClearForm(passwordInput);

            Thread.Sleep(TimeSpan.FromSeconds(2));
        }
        void ClearForm(IWebElement element)
        {
            element.Clear();
        }
        static object[] InvalidLoginData()
        {
            return new object[]
            {
                new object[] {"abc@xyz.com","1234"},
                new object[] {"qwe@xyz.com","456"}
            };
        }
        

    }
}

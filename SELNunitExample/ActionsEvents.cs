using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SELNunitExample
{
    [TestFixture]
    internal class ActionsEvents : CoreCodes
    {
        [Test]

        public void HomeLinksCheck()
        {
            IWebElement homeLink = driver.FindElement(By.LinkText("Home"));
            IWebElement tdhomeLink = driver.FindElement(By.XPath("/html/body/div" +
                "/table/tbody/tr/td" + "/table/tbody/tr/td" +
                "/table/tbody/tr/td/" + "/table/tbody/tr"));

            Actions actions = new Actions(driver);
            Action mouseOverHomeLink = () => actions.MoveToElement(homeLink).Build().Perform();
            Console.WriteLine("Before :" + tdhomeLink.GetCssValue("background-color"));
            mouseOverHomeLink.Invoke();
            Console.WriteLine("After :" + tdhomeLink.GetCssValue("background-color"));
            Thread.Sleep(2000);
        }

        [Test]
        public void MultipleActionsTest() 
        {
            driver.Navigate().GoToUrl("http://www.linkedin.com/");
            DefaultWait<IWebDriver> fluentwait = new DefaultWait<IWebDriver>(driver);
            fluentwait.Timeout = TimeSpan.FromSeconds(5);
            fluentwait.PollingInterval = TimeSpan.FromMilliseconds(100);
            fluentwait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentwait.Message = "Element not Found";

            IWebElement emailInput = fluentwait.Until(driv => driv.FindElement(By.Id("session_key")));
            Actions actions = new Actions(driver);
            Action upperCaseInput = () => actions.KeyDown(Keys.Shift).SendKeys(emailInput,"hello").KeyUp(Keys.Shift).Build().Perform();
            upperCaseInput.Invoke();
            Console.WriteLine("Text is: " + emailInput.GetAttribute("value"));
            Thread.Sleep(3000);
        }
    }
}

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsTest
{
    [TestFixture]
    internal class FlipkartTest : CoreCodes
    {
        [Test]
        public void SearchForLap()
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Product Not Found";



            IWebElement searchinputtestbox = fluentWait.Until(driv => driv.FindElement(By.ClassName("Pke_EE")));

            searchinputtestbox.SendKeys("Laptop");
            
            //IWebElement searchbutton = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/div[1]/div/div/div/div/div[1]/div/div[1]/div/div[1]/div[1]/header/div[1]/div[2]/form/div/button/svg"));
            searchinputtestbox.SendKeys(Keys.Enter);
           
        }
        [Test]
        public void SelectProduct()
        {
            DefaultWait<IWebDriver> fluentWait = new DefaultWait<IWebDriver>(driver);
            fluentWait.Timeout = TimeSpan.FromSeconds(5);
            fluentWait.PollingInterval = TimeSpan.FromMilliseconds(100);
            fluentWait.IgnoreExceptionTypes(typeof(NoSuchElementException));
            fluentWait.Message = "Product Not Found";

            IWebElement selectproduct = fluentWait.Until(driv => driv.FindElement(By.ClassName("_4rR01T")));
            selectproduct.Click();

            

        }
    }
}

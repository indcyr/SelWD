using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SELNunitExample
{
    [TestFixture]
    internal class GHPTests : CoreCodes
    {
        [Ignore("other")]
        [Test]
        public void TitleTest()
        {
            Thread.Sleep(2000);
            Assert.AreEqual("Google", driver.Title);
            Console.WriteLine("Title Test - Pass");

        }
        [Ignore("other")]
        [Test]
        [Order(20)]
        public void GSTest()
        {
            IWebElement searchinputtestbox = driver.FindElement(By.Id("APjFqb"));
            searchinputtestbox.SendKeys("HP Laptop");
            Thread.Sleep(2000);
            IWebElement gsbutton = driver.FindElement(By.Name("btnK"));
            gsbutton.Click();
            Assert.AreEqual("HP Laptop - Google Search", driver.Title);
            Console.WriteLine("GS-Pass");

        }
        [Ignore("other")]
        [Test]
        public void AllLinksStatusTest()
        {
            List<IWebElement> allLinks = driver.FindElements(By.TagName("a")).ToList();
            
            foreach(var  link in allLinks)
            {
                string url = link.GetAttribute("href");
                if(url==null)
                {
                    Console.WriteLine("Url is null");
                    continue;

                }
                else
                {
                    bool isworking = CheckLinkStatus(url);
                    if(isworking)
                        Console.WriteLine(url + "is working");
                    else
                        Console.WriteLine(url + "is not working");
                }
            }

        }
       
    }
}

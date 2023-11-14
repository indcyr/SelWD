using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium.Edge;

namespace SeleniumEx
{
    internal class GHPTest
    {
        IWebDriver? driver;
        public void InitializeEdgeDriver()
        {
            driver = new EdgeDriver();

            driver.Url = "https://www.google.com";

        }
        public void InitializeChromeDriver()
        {
            driver = new ChromeDriver();

            driver.Url = "https://www.google.com";

        }
        public void TitleTest()
        {
            Thread.Sleep(2000);
            //string title = driver.Title;
            Console.WriteLine("Title" + driver.Title);
            Console.WriteLine("Title Length" + driver.Title.Length);
            Assert.AreEqual("Google", driver.Title);
            Console.WriteLine("Title Test - Pass");

        }
        public void PageSourceandURLTest()
        {
            //Console.WriteLine("PS" + driver.PageSource);
            //Console.WriteLine("PS Length" + driver.PageSource.Length);
            //Console.WriteLine(driver.Url);
            Assert.AreEqual("https://www.google.com/",driver.Url);
            Console.WriteLine("Url test- pass");
        }
       
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
        public void GmailLinkTest()
        {

            driver.Navigate().Back();
            driver.FindElement(By.PartialLinkText("ma")).Click();
            Thread.Sleep(3000);
            //string title =driver.Title;
            //Assert.That(title.Contains("Gmail"));
            Assert.That(driver.Url.Contains("gmail"));
            Console.WriteLine("Gmail - Pass");
        }
        public void ImageslLinkTest()
        {
            Thread.Sleep(5000);
            driver.Navigate().Back();
            driver.FindElement(By.PartialLinkText("mag")).Click();
            Thread.Sleep(3000);
            string title = driver.Title;
            //Assert.That(title.Contains("Gmail"));
            Assert.That(driver.Title.Contains("Images"));
            Console.WriteLine("Images - Pass");
        }
        public void LocalizationTest()
        {
            driver.Navigate().Back();
            string loc = driver.FindElement(By.XPath("/html/body/div[1]/div[6]/div[1]")).Text;
            Thread.Sleep(3000);
            string title = driver.Title;
            //Assert.That(title.Contains("Gmail"));
            Assert.That(loc.Equals("India"));
            Console.WriteLine("Loc - Pass");
        }
        public void GAppYoutubeTest()
        {
            driver.FindElement(By.ClassName("gb_d")).Click();
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("MrEfLc")).Click();
            Assert.That(driver.Url.Contains("youtube"));
            Console.WriteLine("Youtube - pass");

        }
        public void Destruct()
        {
            driver.Close();
        }
    }
}

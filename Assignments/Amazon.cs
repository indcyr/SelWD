using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    internal class Amazon
    {
        IWebDriver? driver;

      
        public void AccessAmazon()
        {
            driver = new ChromeDriver();//Initializing chrome driver

            driver.Url = "https://www.google.com";//passing google url
            Thread.Sleep(2000);//waiting for 2 seconds
            
            driver.Navigate().GoToUrl("https://www.amazon.com");//Navigating to the given url
            //Console.WriteLine(driver.Title);
            Assert.That(driver.Title.Contains("Amazon.com. Spend less. Smile more."));//checking whether correctly navigated
            Console.WriteLine("Pass");
        }
        public void CheckUrlAmazon() 
        {
            Assert.That(driver.Url.Contains(".com"));//checking whether page is loaded correctly with appropriate org type
            Console.WriteLine("Url -Pass");
        }
        public void Destruct()
        {
            driver.Close();
        }

    }
}

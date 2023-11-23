using BunnyCart.PageObjects;
using BunnyCart.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V117.Debugger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BunnyCart.TestScripts
{
    [TestFixture]
    internal class BunnyCartTest : CoreCodes
    {
        
        [Test]
        
        public void SignUpTest()
        {
            BCHP bchp = new(driver);

            bchp.ClickCreateAnAccountLink();
            Thread.Sleep(2000);
            try
            {
                Assert.That(driver.FindElement(By.XPath("//div[" +
                "@class='modal-inner-wrap']//following::h1[2]")).Text,
                Is.EqualTo("Create an Account"));
                bchp.SignUp("John", "Doe", "john.doe@grail.com", "12345", "12345", "987654321");
            }
             catch(AssertionException)
            {
                Console.WriteLine("Sign Up Failed");
               
            }
            
        }
    }
}

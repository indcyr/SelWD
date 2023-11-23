using Rediff.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rediff.TestScripts
{
    [TestFixture]
    internal class UserMgmtTests : CoreCodes
    {
        //Asserts
        //[Test, Order(1), Category("Smoke test")]
        //public void CreateAccountLinkTest()
        //{
        //    var homepage = new RediffHomePage(driver);
        //    driver.Navigate().GoToUrl("http://www.rediff.com/");
        //    homepage.CreateAccountClick();
        //    Assert.That(driver.Url.Contains("register"));
        //}
        //[Test, Order(2), Category("Smoke test")]
        //public void SignInLinkTest()
        //{
        //    var homepage = new RediffHomePage(driver);
        //    driver.Navigate().GoToUrl("http://www.rediff.com/");
        //    homepage.SignInLinkClick();
        //    Assert.That(driver.Url.Contains("login"));
        //}
        //[Test, Order(1), Category("Regression test")]
        //public void CreateAccountTest()
        //{
        //    var homepage = new RediffHomePage(driver);
        //    if(!driver.Url.Equals("http://www.rediff.com/"))
        //    {
        //        driver.Navigate().GoToUrl("http://www.rediff.com/");
        //    }
        //    var createaccountpage = homepage.CreateAccountClick();
        //    Thread.Sleep(2000);
        //    createaccountpage.FullNameType("xxx");
        //    createaccountpage.RediffmailType("xxx@gmail.com");
        //    createaccountpage.CheckAvailabilityBtnClick();
        //    Thread.Sleep(2000);
        //    createaccountpage.CreateMyAcctBtnClick();

        //}
        [Test, Order(2), Category("Regression test")]
        public void SignInTest()
        {
            var homepage = new RediffHomePage(driver);
            if (!driver.Url.Equals("http://www.rediff.com/"))
            {
                driver.Navigate().GoToUrl("http://www.rediff.com/");
            }
            var signinpage = homepage.SignInClick();
            Thread.Sleep(2000);
            signinpage.TypeUserName("xxx");
            signinpage.TypePassword("xxxpwd");
            signinpage.ClickRememberMeChkbx();
            Assert.False(signinpage?.RememberMeChkbx?.Selected);
            Thread.Sleep(3000);
            signinpage?.SignInBtnClick();
            Assert.True(true);

        }
    }
}

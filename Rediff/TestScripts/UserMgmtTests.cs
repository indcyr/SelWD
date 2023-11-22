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
        [Test]
        public void CreateAccountLinkTest()
        {
            var homepage = new RediffHomePage(driver);
            homepage.CreateAccountClick();
            Assert.That(driver.Title.Contains("register"));
        }
    }
}

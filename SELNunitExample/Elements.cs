using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SELNunitExample
{
    internal class Elements : CoreCodes
    {
        [Ignore("")]
        [Test]
        public void TestCheckBox()
        {
           // Thread.Sleep(3000);
            //IWebElement elements = driver.FindElement(By.XPath("//h5[text()='Elements']"));
            //elements.Click();

            //IWebElement cbmenu = driver.FindElement(By.XPath("//span[text()='Check Box']"));
            //cbmenu.Click();

            //List<IWebElement> expandcollapse = driver.FindElements(By.ClassName("rct-collapse rct-colapse-btn")).ToList();
            //foreach(var item in expandcollapse)
            //{
            //    item.Click();
            //}
            //IWebElement commandscheckbox = driver.FindElement(By.XPath("//span[text()='Commands']"));
            //commandscheckbox.Click();

           // Assert.True(driver.FindElement(By.XPath("//input[contains(@id,'commands')]")).Selected);
        }
        [Ignore("")]
        [Test]
        public void TestFormElements()
        {
            Thread.Sleep(2000);
            IWebElement firstNameField = driver.FindElement(By.Id("firstName"));
            firstNameField.SendKeys("John");
            Thread.Sleep(2000);

            IWebElement lastNameField = driver.FindElement(By.Id("lastName"));
            lastNameField.SendKeys("Doe");
            Thread.Sleep(2000);

            IWebElement emailField = driver.FindElement(By.XPath("//input[@id='userEmail']"));
            emailField.SendKeys("myid@yahoo.com");
            Thread.Sleep(2000);

            IWebElement genderField = driver.FindElement(By.XPath("//input[@id='gender-radio-1']//following::label"));
            genderField.Click();
            Thread.Sleep(2000);

            IWebElement mobileNoField = driver.FindElement(By.Id("userNumber"));
            mobileNoField.SendKeys("7865545656");
            Thread.Sleep(2000);

            IWebElement dobField = driver.FindElement(By.Id("dateOfBirthInput"));
            dobField.Click();
            Thread.Sleep(2000);

            IWebElement dobMonth = driver.FindElement(By.ClassName("react-datepicker__month-select"));
            SelectElement selectMonth = new SelectElement(dobMonth);
            selectMonth.SelectByIndex(5);
            Thread.Sleep(2000);

            IWebElement dobYear = driver.FindElement(By.ClassName("react-datepicker__year-select"));
            SelectElement selectYear = new SelectElement(dobYear);
            selectYear.SelectByText("1990");
            Thread.Sleep(2000);

            IWebElement dobDay = driver.FindElement(By.XPath("//div[@class='react-datepicker__day react-datepicker__day--005']"));
            dobDay.Click();
            Thread.Sleep(2000);

            IWebElement subjectField = driver.FindElement(By.Id("subjectsInput"));
            subjectField.SendKeys("Maths");
            subjectField.SendKeys(Keys.Enter);
            Thread.Sleep(2000);
            subjectField.SendKeys("Chemistry");
            subjectField.SendKeys(Keys.Enter);
            Thread.Sleep(2000);

            IWebElement hobbiesCheckbox = driver.FindElement(By.XPath("//Label[text()='Sports']"));
            hobbiesCheckbox.Click();
            Thread.Sleep(2000);

            IWebElement uploadPicture = driver.FindElement(By.Id("uploadPicture"));
            uploadPicture.SendKeys(@"C:\Users\Administrator\Pictures\photo");


        }
        [Ignore("")]
        [Test]
        public void TestWindows()
        {
            driver.Url = "https://demoqa.com/browser-windows";
            string parentWindowHandle = driver.CurrentWindowHandle;
            Console.WriteLine("Parent Window's Handle:" + parentWindowHandle);
            IWebElement clickElement = driver.FindElement(By.Id("tabButton"));

            for(var i =0; i < 3; i++)
            {
                clickElement.Click();
                Thread.Sleep(2000);
            }
            List<string> lstWindow = driver.WindowHandles.ToList();

            String lastWindowHandle = "";
            foreach(var handle in lstWindow)
            {
                Console.WriteLine("Switching to window - > " + handle);
                driver.SwitchTo().Window(handle);

                Console.WriteLine("Navigating to google.com");
                driver.Navigate().GoToUrl("http://google.com");
                Thread.Sleep(2000);

                lastWindowHandle = handle;
            }
            driver.SwitchTo().Window(parentWindowHandle);
            driver.Close();
        }
        [Test]
        public void TestAlerts()
        {
            driver.Url = "https://demoqa.com/alerts";

            IWebElement element = driver.FindElement(By.Id("alertButton"));
            Thread.Sleep(5000);
            ((IJavaScriptExecutor)driver).ExecuteScript("arguments[0].click()", element);

            IAlert simpleAlert = driver.SwitchTo().Alert();
            Console.WriteLine("Alert text is" + simpleAlert.Text);

            simpleAlert.Accept();
            Thread.Sleep(5000);

            element = driver.FindElement(By.Id("confirmButton"));
            Thread.Sleep(5000);
            element.Click();

            IAlert confirmationAlert = driver.SwitchTo().Alert();
            string alertText = confirmationAlert.Text;
            Console.WriteLine("Alert text is" + alertText);

            confirmationAlert.Dismiss();

            element = driver.FindElement(By.Id("promptButton"));
            element.Click();
            Thread.Sleep(5000);
            

            IAlert promptAlert = driver.SwitchTo().Alert();
            alertText = promptAlert.Text;
            Console.WriteLine("Alert text is" + alertText);

            promptAlert.SendKeys("Accepting the alert");
            Thread.Sleep(5000);
            promptAlert.Accept();

        }

    }
}

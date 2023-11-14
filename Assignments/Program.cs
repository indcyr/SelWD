using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Assignments;

Amazon amazon = new Amazon();

try
{


amazon.AccessAmazon();
    amazon.CheckUrlAmazon();
}
catch (AssertionException)
{
    Console.WriteLine("Test - Fail");
}
amazon.Destruct();
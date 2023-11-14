using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Assignments;
using Assignment;


//14-11-23
//Assignment 1
//Amazon amazon = new Amazon();

//try
//{


//amazon.AccessAmazon();
//    amazon.CheckUrlAmazon();
//}
//catch (AssertionException)
//{
//    Console.WriteLine("Test - Fail");
//}
//amazon.Destruct();


//14-11-23
//Assignment 2

LaunchNewBrowser launchNewBrowser = new LaunchNewBrowser();
try
{
    launchNewBrowser.InitializeChromeDriver(); //calling intialize method
    launchNewBrowser.SearchResultTest(); // calling SearchResulTest  method

}
catch (AssertionException)
{
    Console.WriteLine(" Title Test failed");
}
launchNewBrowser.Destruct();
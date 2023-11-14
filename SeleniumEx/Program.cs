using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumEx;

GHPTest gHPTest = new GHPTest();

List<string> drivers = new List<string>();
//drivers.Add("Edge");
drivers.Add("Chrome");

foreach (var d in drivers)
{
    switch(d)
    {
        case "Edge":
            gHPTest.InitializeEdgeDriver();
            break;
        case "Chrome":
            gHPTest.InitializeChromeDriver();
            break;

    }
    try
    {
        //gHPTest.TitleTest();
        //gHPTest.PageSourceandURLTest();
        //gHPTest.GSTest();
        //gHPTest.GmailLinkTest();
        //gHPTest.ImageslLinkTest();
        //gHPTest.LocalizationTest();
        gHPTest.GAppYoutubeTest();
    }
    catch (AssertionException)
    {

        Console.WriteLine("Test - Fail");
    }

   
}
gHPTest.Destruct();


//Console.WriteLine("1. EDGE 2. CHROME");
//int ch = Convert.ToInt32(Console.ReadLine());
//switch(ch)
//{
//    case 1: 
//        gHPTest.InitializeEdgeDriver();
//        break;
//    case 2:
//        gHPTest.InitializeChromeDriver();
//        break;
//}

//driver.Close();

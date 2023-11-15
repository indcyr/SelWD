using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumEx;



List<string> drivers = new List<string>();
//drivers.Add("Edge");
drivers.Add("Chrome");



foreach (var d in drivers)
{
    AmazonTest az = new AmazonTest();
    switch (d)
    {
        case "Edge":
            az.InitializeEdgeDriver();
            break;
        case "Chrome":
            az.InitializeChromeDriver();
            break;

    }
    try
    {
        //az.TitleTest();
        //az.LogoClickTest();
        //az.SearchProductTest();
        //az.ReloadHomePage();
        //az.TodaysDealsTest();
        // az.SignInAccList();
        az.SearchandFilterProductByBrand();
    }
    catch (AssertionException)
    {

        Console.WriteLine("Fail");
    }
    catch (NoSuchElementException nse)
    {
        Console.WriteLine(nse.Message);
    }

    az.Destruct();

}


//GHPTest gHPTest = new GHPTest();

//List<string> drivers = new List<string>();
////drivers.Add("Edge");
//drivers.Add("Chrome");

//    foreach (var d in drivers)
//{
//    switch(d)
//    {
//        case "Edge":
//            gHPTest.InitializeEdgeDriver();
//            break;
//        case "Chrome":
//            gHPTest.InitializeChromeDriver();
//            break;

//    }
//try
//{
//gHPTest.TitleTest();
//gHPTest.PageSourceandURLTest();
//gHPTest.GSTest();
//gHPTest.GmailLinkTest();
//gHPTest.ImageslLinkTest();
//gHPTest.LocalizationTest();
//gHPTest.GAppYoutubeTest();
//    }
//    catch (AssertionException)
//    {

//        Console.WriteLine("Test - Fail");
//    }

   
//}
//gHPTest.Destruct();


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

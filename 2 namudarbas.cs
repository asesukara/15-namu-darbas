using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Safari;
using System;

namespace ClassLibrary1
{
    public class TrysSvetainesTest
    {
        //..................................................1 asis namu darbas......................................
        //.................................................GALIMAI BLOGAS SPRENDIMAS.................................
        //    private static IWebDriver chromeDriver, firefoxDriver, safariDriver;

        //    [OneTimeSetUp]
        //    public static void ThreeAllDrivers()/*??????????????????????//*/
        //    {
        //        chromeDriver = new ChromeDriver();
        //        chromeDriver.Url =
        //          "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
        //        chromeDriver.Manage().Window.Maximize();
        //        chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        //        firefoxDriver = new FirefoxDriver();
        //        firefoxDriver.Url =
        //          "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
        //        firefoxDriver.Manage().Window.Maximize();
        //        firefoxDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

        //        safariDriver = new SafariDriver();
        //        safariDriver.Url =
        //          "http://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
        //        safariDriver.Manage().Window.Maximize();
        //        safariDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        //    }
        //    [OneTimeTearDown]
        //    public static void ThreeDrivers()
        //    {
        //        chromeDriver.Quit();
        //        firefoxDriver.Quit();
        //        safariDriver.Quit();
        //    }
        //    [Test]
        //    public static void WebDriversTest()
        //    {
        //        /*objektas*/
        //        TrysSvetainesPage page = new TrysSvetainesPage(chromeDriver);
        //        page.NavigateToPage();
        //    }

        //}
        //public class TrysSvetainesPage : BasePage
        //{
        //    private /*kintamasis*/ const string pageUrl = "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
        //    public TrysSvetainesPage(IWebDriver webdriver) : base(webdriver) { }/*konstruktorius*/
        //    public void NavigateToPage()
        //    {
        //        if (Driver.Url != pageUrl)
        //        {
        //            Driver.Url = pageUrl;
        //        }
        //    }
        //}


        //        ...............................................................................................................................................................................................................................
        //....................................Sitas Geras sprendimas...........................................

        public class TrysSvetainesSecond
        {
            private static IWebDriver chromeDriver;

            [Test]
            public static void ChromeTest()
            {
                chromeDriver = new ChromeDriver();
                chromeDriver.Url = "http://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
                chromeDriver.Manage().Window.Maximize();
                chromeDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                chromeDriver.Quit();
            }
            private static IWebDriver firefoxDriver;

            [Test]
            public static void FirefoxTest()
            {
                firefoxDriver = new FirefoxDriver();
                firefoxDriver.Url = "http://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
                firefoxDriver.Manage().Window.Maximize();
                firefoxDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                firefoxDriver.Quit();
            }
            private static IWebDriver safariDriver;

            [Test]
            public static void SafariTest()
            {
                safariDriver = new SafariDriver();
                safariDriver.Url = "http://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
                safariDriver.Manage().Window.Maximize();
                safariDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
                safariDriver.Quit();
            }



        }
    }
}

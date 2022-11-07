using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Firefox;
using System;

namespace ClassLibrary1
{


    public class ThreeDrivers
    {

        [TestCase("Chrome", "Chrome 107 on Windows 10", TestName = "Test Chrome")]
        [TestCase("Firefox", "Firefox 106 on Windows 10", TestName = "Test Firefox")]
        [TestCase("Edge", "Edge 107 on Windows 10", TestName = "Test Edge")]
        public static void TestBrowsers(string browser, string text)
        {
            IWebDriver driver = null;
            if ("Chrome".Equals(browser))
            {
                driver = new ChromeDriver();
            }
            if ("Firefox".Equals(browser))
            {
                driver = new FirefoxDriver();
            }
            if ("Edge".Equals(browser))
            {
                driver = new EdgeDriver();
            }

            driver.Url =
              "https://developers.whatismybrowser.com/useragents/parse/?analyse-my-user-agent=yes#parse-useragent";
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            IWebElement resultElement = driver.FindElement(By.CssSelector(".simple-major"));


            Assert.AreEqual(text, resultElement.Text, "Browser is not this Browser");
            driver.Quit();
        }

    }





}


//        ...............................................................................................................................................................................................................................
//....................................Sitas Geras sprendimas...........................................




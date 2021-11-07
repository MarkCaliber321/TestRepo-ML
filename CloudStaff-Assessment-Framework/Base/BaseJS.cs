using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;
using System.Threading;

namespace CloudStaff_Assessment_Framework.Base
{
    public class BaseJS
    {
        public IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("chromedriverpath");
            driver.Url = "https://the-internet.herokuapp.com/javascript_alerts";
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void closeBrowser()
        {
            Thread.Sleep(3000);
            driver.Close();

        }

    }
}
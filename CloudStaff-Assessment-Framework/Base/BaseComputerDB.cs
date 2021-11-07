
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;


namespace CloudStaff_Assessment_Framework.Base
{
    public class BaseComputerDb
    {
        public IWebDriver driver;

        [SetUp]
        public void startBrowser1()
        {
            driver = new ChromeDriver("chromedriver path")
            {
                Url = "http://computer-database.gatling.io/computers"
            };
            driver.Manage().Window.Maximize();
        }

        [TearDown]
        public void closeBrowser1()
        {
            driver.Close();

        }

    }
}
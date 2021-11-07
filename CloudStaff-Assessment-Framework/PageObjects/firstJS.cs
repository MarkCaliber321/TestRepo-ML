using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using NUnit.Framework;
using System.Threading;

namespace CloudStaff_Assessment_Framework.PageObjects
{
    public class firstJS
    {
        IWebDriver driver;
        public firstJS(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/ul/li[1]/button")]
        public IWebElement JSAlert1 { get; set; }

        public void clickJS1()
        {
            JSAlert1.Click();
            IAlert alert = driver.SwitchTo().Alert();
            Thread.Sleep(3000);
            alert.Accept();
        }


    }
}

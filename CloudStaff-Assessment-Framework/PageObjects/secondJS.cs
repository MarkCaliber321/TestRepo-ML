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
    public class secondJS
    {
        IWebDriver driver;
        public secondJS(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/ul/li[2]/button")]
        public IWebElement JSAlert2 { get; set; }

        public void clickJS2()
        {
            JSAlert2.Click();
            IAlert alert = driver.SwitchTo().Alert();
            Thread.Sleep(3000);
            alert.Accept();
            JSAlert2.Click();
            Thread.Sleep(3000);
            alert.Dismiss();

        }


    }
}

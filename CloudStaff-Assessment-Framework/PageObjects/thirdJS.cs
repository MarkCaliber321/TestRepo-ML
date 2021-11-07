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
    public class thirdJS
    {
        IWebDriver driver;
        public thirdJS(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/div/ul/li[3]/button")]
        public IWebElement JSAlert3 { get; set; }

        public void clickJS3()
        {
            JSAlert3.Click();
            IAlert alert = driver.SwitchTo().Alert();
            Thread.Sleep(3000);
            alert.SendKeys("Alyssa");
            Thread.Sleep(3000);
            alert.Accept();
        }


    }
}

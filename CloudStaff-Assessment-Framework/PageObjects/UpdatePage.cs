using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using System.Threading;

namespace CloudStaff_Assessment_Framework.PageObjects
{
    public class UpdatePage
    {
        IWebDriver driver;
        public UpdatePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "discontinued")]
        public IWebElement DiscontinuedTextbox { get; set; }
        [FindsBy(How = How.XPath, Using = "//*[@id='main']/form[1]/div/input")]
        public IWebElement Submit { get; set; }

        public void UpdateComputerRecord()
        {
            DiscontinuedTextbox.SendKeys("2021-11-08");
            Thread.Sleep(3000);
            Submit.Click();
        }
    }
}

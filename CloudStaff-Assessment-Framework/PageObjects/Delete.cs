using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using System.Threading;

namespace CloudStaff_Assessment_Framework.PageObjects
{
    public class Delete
    {
        IWebDriver driver;
        public Delete(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/form[2]/input")]
        public IWebElement deleteButton { get; set; }
        public IWebElement Submit { get; set; }

        public void ClickDeleteButton()
        {
            Thread.Sleep(3000);

            deleteButton.Click();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace CloudStaff_Assessment_Framework.PageObjects
{
    public class Update
    {
        IWebDriver driver;
        public Update(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/section/table/tbody/tr[2]/td[1]/a")]
        public IWebElement SecondComputer { get; set; }

        public UpdatePage ClickRecord()
        {
            SecondComputer.Click();
            return new UpdatePage(driver);
        }

        public Delete DeleteRecord()
        {
            return new Delete(driver);
        }

        public Read ReadRecord()
        {

            return new Read(driver);
        }
    }

}
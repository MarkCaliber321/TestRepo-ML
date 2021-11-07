using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace CloudStaff_Assessment_Framework.PageObjects
{

    public class Create
    {
        IWebDriver driver;
        public Create(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "add")]

        public IWebElement CreateComputer { get; set; }



        public CreateNewPage CreateNewRecord()
        {
            CreateComputer.Click();
            return new CreateNewPage(driver);
        }

    }
}

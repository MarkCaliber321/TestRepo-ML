using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using System.Threading;


namespace CloudStaff_Assessment_Framework.PageObjects
{
    public class CreateNewPage
    {
        IWebDriver driver;
        public CreateNewPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.Id, Using = "name")]
        public IWebElement ComputerNameTextbox { get; set; }

        [FindsBy(How = How.Id, Using = "introduced")]
        public IWebElement IntroducedTextbox { get; set; }

        [FindsBy(How = How.Id, Using = "discontinued")]
        public IWebElement DiscontinuedTextbox { get; set; }

        [FindsBy(How = How.Id, Using = "company")]
        public IWebElement CompanyDropdown { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input.btn.primary")]
        public IWebElement SubmitButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='company']/option[14]")]
        public IWebElement OptionIBM { get; set; }
        [FindsBy(How = How.CssSelector, Using = "input.btn.primary")]
        public IWebElement Submit { get; set; }

        public void CreateComputerRecord()
        {
            ComputerNameTextbox.SendKeys("Alyssa");
            Thread.Sleep(3000);
            IntroducedTextbox.SendKeys("2021-11-05");
            Thread.Sleep(3000);
            DiscontinuedTextbox.SendKeys("2021-11-08");
            Thread.Sleep(3000);
            CompanyDropdown.Click();
            Thread.Sleep(3000);
            OptionIBM.Click();

            Submit.Click();
        }
    }
}

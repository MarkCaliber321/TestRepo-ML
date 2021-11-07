using System;
using System.Collections.Generic;
using System.Text;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;
using System.Threading;
using NUnit.Framework;

namespace CloudStaff_Assessment_Framework.PageObjects
{
    public class Read
    {
        IWebDriver driver;
        public Read(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.XPath, Using = "/html/body/section/table/tbody/tr[2]/td[1]/a")]
        public IWebElement firstcolumn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/table/tbody/tr[2]/td[2]")]
        public IWebElement secondcolumn { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='main']/table/tbody/tr[3]/td[4]")]
        public IWebElement fourthcolumn { get; set; }

        public String getfirstcolumn()
        {
            Thread.Sleep(3000);
            return
                firstcolumn.Text;
        }
        public String getSecondColumn()
        {
            Thread.Sleep(3000);
            return
                secondcolumn.Text;

        }
        public String getaFourthColumn()
        {
            Thread.Sleep(3000);
            return
                fourthcolumn.Text;


        }

        String expectedfirstcolumn = "AN/FSQ-32";
        String expectedsecondcolumn = "01 Jan 1960";
        String expectedfourthcolumn = "IBM";
        public String expectedfirstc()
        {
            return expectedfirstcolumn;
        }
        public String expectedsecondc()
        {
            return expectedsecondcolumn;
        }
        public String expectedfourthc()
        {
            return expectedfourthcolumn;
        }




    }
}
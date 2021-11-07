using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using SeleniumExtras.PageObjects;
using CloudStaff_Assessment_Framework.PageObjects;
using System.Threading;
using CloudStaff_Assessment_Framework.Base;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace CloudStaff_Assessment_Framework.Test_Scripts
{
    [TestFixture]
    public class JavaScriptAlertTestRun : BaseJS
    {
        [Test]
        public void TestMethod2()
        {
            var js = new firstJS(driver);
            Thread.Sleep(3000);
            js.clickJS1();
            var js2 = new secondJS(driver);
            Thread.Sleep(3000);
            js2.clickJS2();
            var js3 = new thirdJS(driver);
            Thread.Sleep(3000);
            js3.clickJS3();
        }

    }

}


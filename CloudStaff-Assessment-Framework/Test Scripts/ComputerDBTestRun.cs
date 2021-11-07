using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using SeleniumExtras.PageObjects;
using CloudStaff_Assessment_Framework.Test_Scripts;
using System.Threading;
using CloudStaff_Assessment_Framework.Base;
using CloudStaff_Assessment_Framework.PageObjects;

namespace CloudStaff_Assessment_Framework.Test_Scripts
{
    [TestFixture]
    public class ComputerDBTestRun : BaseComputerDb
    {
        [Test]
        public void TestMethod1()
        {

            var create = new Create(driver);
            Thread.Sleep(3000);
            var createnewpage = create.CreateNewRecord();
            Thread.Sleep(3000);
            createnewpage.CreateComputerRecord();
            Thread.Sleep(3000);

            var update = new Update(driver);
            Thread.Sleep(3000);
            var updatepage = update.ClickRecord();
            updatepage.UpdateComputerRecord();

            var delete = new Update(driver);
            Thread.Sleep(3000);
            var deletePage = delete.DeleteRecord();

            var read = new Update(driver);
            Thread.Sleep(3000);
            var readPage = read.ReadRecord();

            var getfirstcolumn = readPage.getfirstcolumn();
            var expectedfirstcolumn = readPage.expectedfirstc();
            var getsecondcolumn = readPage.getSecondColumn();
            var expectedsecondcolumn = readPage.expectedsecondc();
            var getfourthcolumn = readPage.getaFourthColumn();
            var expectedfourthcolumn = readPage.expectedfourthc();


            Assert.IsTrue(getfirstcolumn.Equals(expectedfirstcolumn));
            Thread.Sleep(3000);
            Assert.IsTrue(getsecondcolumn.Equals(expectedsecondcolumn));
            Thread.Sleep(3000);
            Assert.IsTrue(getfourthcolumn.Equals(expectedfourthcolumn));

        }
    }
}

using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class ManageRequests
    {
        private IWebElement Recieved() => Driver.driver.FindElement(By.XPath(ManageRequests_XPath.RecievedTitle));

        private IWebElement Sent() => Driver.driver.FindElement(By.XPath(ManageRequests_XPath.SentTitle));

        public void ValidRecievedReq()
        {
            Thread.Sleep(1000);
            if (Recieved().Text == "Received Requests")
            {
                Assert.Pass("Record can be viewed");
            }
            else
            {
                Assert.Fail("Record cannot be viewed");
            }
            Thread.Sleep(1000);
        }

        public void ValidSentReq()
        {
            Thread.Sleep(1000);
            if (Sent().Text == "Sent Requests")
            {
                Assert.Pass("Record can be viewed");
            }
            else
            {
                Assert.Fail("Record cannot be viewed");
            }
            Thread.Sleep(1000);
        }
    }
}

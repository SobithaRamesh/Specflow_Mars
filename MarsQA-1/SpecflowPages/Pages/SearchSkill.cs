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
    class SearchSkill
    {

        private IWebElement Srch() => Driver.driver.FindElement(By.XPath(SearchSkill_XPath.Result_Xpath));

        public void Result()
        {
            Thread.Sleep(1000);
            if (Srch().Text == "Refine Result ")
            {
                Thread.Sleep(2000);
                Assert.Fail("Record cannot be viewed");
            }
            else
            {
                Thread.Sleep(2000);
                Assert.Pass("Record can be viewed");
            }
        }
    }
}

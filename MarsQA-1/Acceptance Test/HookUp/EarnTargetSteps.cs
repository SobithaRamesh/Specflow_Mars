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
using TechTalk.SpecFlow;

namespace MarsQA_1.Acceptance_Test.HookUp
{
    [Binding]
    class EarnTargetSteps
    {
        [Given(@"I selects the Earn Target in profile page")]
        public void GivenISelectsTheEarnTargetInProfilePage()
        {
            Driver.driver.FindElement(By.XPath(ProfileDetails_XPath.EarnTarget)).Click();
        }

        [When(@"I updated his/her earn target")]
        public void WhenIUpdatedHisHerEarnTarget()
        {
            Driver.driver.FindElement(By.XPath(ProfileDetails_XPath.Earn_Dropdown)).Click();
            Driver.driver.FindElement(By.XPath(ProfileDetails_XPath.Earn_List)).Click();
        }

        [Then(@"the earn target should be updated")]
        public void ThenTheEarnTargetShouldBeUpdated()
        {
            string check = Driver.driver.FindElement(By.XPath(ProfileDetails_XPath.Earn_Check)).Text;
            string expected = "More than $1000 per month";
            Assert.AreEqual(check, expected);
            Thread.Sleep(2000);
        }

    }
}

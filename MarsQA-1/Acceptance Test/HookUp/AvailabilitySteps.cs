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
    class AvailabilitySteps
    {
        [Given(@"I selects the Availabilty in profile page")]
        public void GivenISelectsTheAvailabiltyInProfilePage()
        {
            Driver.driver.FindElement(By.XPath(ProfileDetails_XPath.Availability)).Click();
        }

        [When(@"I updated the availability")]
        public void WhenIUpdatedTheAvailability()
        {
            Driver.driver.FindElement(By.XPath(ProfileDetails_XPath.Avail_Dropdown)).Click();
            Driver.driver.FindElement(By.XPath(ProfileDetails_XPath.Avail_FullTime)).Click();
        }

        [Then(@"the availability should be updated")]
        public void ThenTheAvailabilityShouldBeUpdated()
        {
            string check = Driver.driver.FindElement(By.XPath(ProfileDetails_XPath.Avail_Dropdown)).Text;
            string expected = "Full Time";
            Assert.AreEqual(check, expected);
            Thread.Sleep(100);
        }


    }
}

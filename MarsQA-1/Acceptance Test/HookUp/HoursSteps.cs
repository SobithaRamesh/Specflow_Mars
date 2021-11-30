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
    class HoursSteps
    {
        [Given(@"I selects the hours in profile page")]
        public void GivenISelectsTheHoursInProfilePage()
        {
            Driver.driver.FindElement(By.XPath(ProfileDetails_XPath.Hours)).Click();
        }

        [When(@"I updated his/her hours")]
        public void WhenIUpdatedHisHerHours()
        {
            Driver.driver.FindElement(By.XPath(ProfileDetails_XPath.Hours_Dropdown)).Click();
            Driver.driver.FindElement(By.XPath(ProfileDetails_XPath.Hours_list)).Click();
        }

        [Then(@"the hours should be updated")]
        public void ThenTheHoursShouldBeUpdated()
        {
            string check = Driver.driver.FindElement(By.XPath(ProfileDetails_XPath.Hours_Check)).Text;
            string expected = "Less than 30hours a week";
            Assert.AreEqual(check, expected);
            Thread.Sleep(2000);
        }

    }
}

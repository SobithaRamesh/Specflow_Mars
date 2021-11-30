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
    class DescriptionSteps
    {
        [Given(@"I selects the Description in profile page")]
        public void GivenISelectsTheDescriptionInProfilePage()
        {
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath(ProfileDetails_XPath.Description)).Click();
            Thread.Sleep(1000);
        }

        [When(@"I add description")]
        public void WhenIAddDescription()
        {
            Driver.driver.FindElement(By.XPath(ProfileDetails_XPath.Desc_TextBox)).Clear();
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath(ProfileDetails_XPath.Desc_TextBox)).SendKeys("Test Analyst");
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath(ProfileDetails_XPath.Desc_Save)).Click();
        }

        [Then(@"the description should be saved successfully")]
        public void ThenTheDescriptionShouldBeSavedSuccessfully()
        {
            string check = Driver.driver.FindElement(By.XPath(ProfileDetails_XPath.Desc_Check)).Text;
            string expected = "Test Analyst";
            Assert.AreEqual(check, expected);
        }

    }
}

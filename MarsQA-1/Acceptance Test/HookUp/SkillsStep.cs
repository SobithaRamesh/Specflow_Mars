using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
    class SkillsStep
    {
        [Given(@"I selects the skills tab in profile page")]
        public void GivenISelectsTheSkillsTabInProfilePage()
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.SkillTab_XPath)).Click();
        }

        [Given(@"I Click AddNew button")]
        public void GivenIClickAddNewButton()
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.AddNewBtn_XPath)).Click();
        }

        [Given(@"I Enter (.*) and (.*)")]
        public void GivenIEnterAnd(string skill, string Slevel)
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.AddSkillTextBox_Xpath)).SendKeys(skill);
            Thread.Sleep(1000);
            SelectElement LevelSelect = new SelectElement(Driver.driver.FindElement(By.XPath(XPathHelper.SkillLevelDropdown_XPath)));
            LevelSelect.SelectByValue(Slevel);
        }

        [When(@"I Click Add button")]
        public void WhenIClickAddButton()
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.AddBtn_XPath)).Click();
        }

        [Then(@"(.*) should be added successfully")]
        public void ThenShouldBeAddedSuccessfully(string skill)
        {
            String msg = Driver.driver.FindElement(By.XPath("//div[@data-tab='second']//td[1]")).Text;
            Assert.AreEqual(skill, msg);
        }

        [Given(@"I clicks Update icon")]
        public void GivenIClicksUpdateIcon()
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.UpdateIcon_Xpath)).Click();
        }

        [Given(@"I Update (.*) and (.*)")]
        public void GivenIUpdateAnd(string skillUpdate, string SlevelUpdate)
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.AddSkillTextBox_Xpath)).Clear();
            Driver.driver.FindElement(By.XPath(XPathHelper.AddSkillTextBox_Xpath)).SendKeys(skillUpdate);
            Thread.Sleep(1000);
            SelectElement LevelSelect = new SelectElement(Driver.driver.FindElement(By.XPath(XPathHelper.SkillLevelDropdown_XPath)));
            LevelSelect.SelectByValue(SlevelUpdate);
        }

        [When(@"I Click Update button")]
        public void WhenIClickUpdateButton()
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.UpdateBtn_Xpath)).Click();
        }

        [Then(@"(.*) should be updated successfully")]
        public void ThenShouldBeUpdatedSuccessfully(string skillUpdate)
        {
            Thread.Sleep(1000);
            String msg = Driver.driver.FindElement(By.XPath("//div[@data-tab='second']//td[1]")).Text;
            Assert.AreEqual(skillUpdate, msg);
        }

        [When(@"I Clicks delete icon")]
        public void WhenIClicksDeleteIcon()
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.DeleteIcon_Xpath)).Click();
        }

        [Then(@"The (.*)  should be deleted")]
        public void ThenTheShouldBeDeleted(string skillDelete)
        {
            Thread.Sleep(1000);
            string pop = Driver.driver.FindElement(By.XPath(Notification_XPath.PopUp_Xpath)).Text;
            string expected = "Testing has been deleted";
            Assert.AreEqual(pop, expected);
        }


    }
}

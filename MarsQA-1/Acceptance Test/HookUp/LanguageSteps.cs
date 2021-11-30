using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using MarsQA_1.SpecflowPages.Pages;
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

namespace MarsQA_1.Feature
{
    [Binding]
    class LanguageSteps
    {
        
        [Given(@"I selects the language tab in profile page")]
        public void GivenISelectsTheLanguageTabInProfilePage()
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.LangTab_XPath)).Click();
        }

        [Given(@"I clicks AddNew button")]
        public void GivenIClicksAddNewButton()
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.LangAddNewBtn_XPath)).Click();
        }

        [Given(@"I enter (.*) and (.*)")]
        public void AndIEnterAnd(string lang, string level)
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.AddLangTextBox_Xpath)).SendKeys(lang);
            Thread.Sleep(1000);
            SelectElement LevelSelect = new SelectElement(Driver.driver.FindElement(By.XPath(XPathHelper.LangLevelDropdown_XPath)));
            LevelSelect.SelectByValue(level);
        }

        [When(@"I clicks Add button")]
        public void WhenIClicksAddButton()
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.LangAddBtn_XPath)).Click();
        }

        [Then(@"(.*) should be successfully added")]
        public void ThenEnglishShouldBeSuccessfullyAdded(string lang)
        {
            String msg = Driver.driver.FindElement(By.XPath("(//tr)[2]//td[1]")).Text;
            Assert.AreEqual(lang, msg);
        }

        [Given(@"I clicks update icon")]
        public void GivenIClicksUpdateIcon()
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.LangUpdateIcon_XPath)).Click();
        }

        [Given(@"I update (.*) and (.*)")]
        public void GivenIUpdateAnd(string langUpdate, string levelUpdate)
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.AddLangTextBox_Xpath)).Clear();
            Driver.driver.FindElement(By.XPath(XPathHelper.AddLangTextBox_Xpath)).SendKeys(langUpdate);
            Thread.Sleep(1000);
            SelectElement LevelSelect = new SelectElement(Driver.driver.FindElement(By.XPath(XPathHelper.LangLevelDropdown_XPath)));
            LevelSelect.SelectByValue(levelUpdate);
        }

        [When(@"I clicks Update button")]
        public void WhenIClicksUpdateButton()
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.LangUpdateBtn_Xpath)).Click();
        }

        [Then(@"(.*) should be update")]
        public void ThenTeluguShouldBeUpdate(string langUpdate)
        {
            Thread.Sleep(1000);
            String msg = Driver.driver.FindElement(By.XPath("//tr[1]//td[1]")).Text;
            Assert.AreEqual(langUpdate, msg);
        }

        [When(@"I clicks delete icon")]
        public void WhenIClicksDeleteIcon()
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.LangDeleteIcon_XPath)).Click();
        }

        [Then(@"The (.*) should be deleted successfully")]
        public void ThenTheShouldBeDeletedSuccessfully(string langDelete)
        {
            Thread.Sleep(1000);
            string pop = Driver.driver.FindElement(By.XPath(Notification_XPath.PopUp_Xpath)).Text;
            string expected = "Telugu has been deleted from your languages";
            Assert.AreEqual(pop, expected);
        }

    }
}

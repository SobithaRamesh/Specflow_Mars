using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using MarsQA_1.SpecflowPages.Pages;
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
    class SearchSkillSteps
    {
        [Given(@"The seller enters the skill in the Profile Page")]
        public void GivenTheSellerEntersTheSkillInTheProfilePage()
        {
            Driver.driver.FindElement(By.XPath(SearchSkill_XPath.SearchSkillTB_Xpath)).SendKeys("AutoIt");
        }

        [When(@"clicks Search button")]
        public void WhenClicksSearchButton()
        {
            Driver.driver.FindElement(By.XPath(SearchSkill_XPath.SearchBtn_Xpath)).Click();
        }

        [Then(@"Seller can see the list of skills in a page")]
        public void ThenSellerCanSeeTheListOfSkillsInAPage()
        {
            string res = Driver.driver.FindElement(By.XPath(SearchSkill_XPath.Result_Xpath)).Text;
            string expected = "Refine Results";
            Assert.AreEqual(res, expected);
        }

        [Given(@"The seller clicks searchskill button in the Profile Page")]
        public void GivenTheSellerClicksSearchskillButtonInTheProfilePage()
        {
            Driver.driver.FindElement(By.XPath(SearchSkill_XPath.SearchBtn_Xpath)).Click();
        }

        [When(@"Select Category and subcategory of the skill")]
        public void WhenSelectCategoryAndSubcategoryOfTheSkill()
        {
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath(SearchSkill_XPath.Category_Xpath)).Click();
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.XPath(SearchSkill_XPath.SubCategory_Xpath)).Click();
        }

    }
}

using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using MarsQA_1.SpecflowPages.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace MarsQA_1.Acceptance_Test.HookUp
{
    [Binding]
    class ShareSkillSteps
    {
        [Given(@"I selects shareskill button on profile page")]
        public void GivenISelectsShareskillButtonOnProfilePage()
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.ShareSkillBtn_Xpath)).Click();

        }

        [When(@"I enters all the details")]
        public void WhenIEntersAllTheDetails()
        {
            ShareSkill AddShareSkill = new ShareSkill();
            AddShareSkill.EnterShareSkill();
        }

        [Then(@"I should be able to Save the Listings successfully")]
        public void ThenIShouldBeAbleToSaveTheListingsSuccessfully()
        {
            ShareSkill ValidateShareSkill = new ShareSkill();
            ValidateShareSkill.ValidateAddedShareSkill();
        }

    }
}

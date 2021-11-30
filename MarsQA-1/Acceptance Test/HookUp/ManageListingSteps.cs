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
    public class ManageListingSteps
    {
       
        [Given(@"I selects edit icon from the Manage Listings Page")]
        public void GivenISelectsEditIconFromTheManageListingsPage()
        {
            Driver.driver.FindElement(By.XPath(ManageListing_XPath.ML_Tab_Xpath)).Click();
        }

        [When(@"I Updates the details of the Listing")]
        public void WhenIUpdatesTheDetailsOfTheListing()
        {
            ManageListing EditShareSkill = new ManageListing();
            EditShareSkill.EditManageListing();
        }

        [Then(@"I should be able to see the updated listing")]
        public void ThenIShouldBeAbleToSeeTheUpdatedListing()
        {

            ManageListing ValidateML = new ManageListing();
            ValidateML.ValidateEdit();
        }

        [Given(@"I selects delete icon from the Manage Listings Page")]
        public void GivenISelectsDeleteIconFromTheManageListingsPage()
        {
            Driver.driver.FindElement(By.XPath(ManageListing_XPath.ML_Tab_Xpath)).Click();
            Driver.driver.FindElement(By.XPath(ManageListing_XPath.Delete_Xpath)).Click();
        }

        [When(@"I deletes the Listing")]
        public void WhenIDeletesTheListing()
        {
            ManageListing Delete = new ManageListing();
            Delete.DeleteManageListing();
        }

        [Then(@"I should not be able to see that deleted listing")]
        public void ThenIShouldNotBeAbleToSeeThatDeletedListing()
        {
            Thread.Sleep(1000);
            string pop = Driver.driver.FindElement(By.XPath(Notification_XPath.PopUp_Xpath)).Text;
            string expected = "Postman has been deleted";
            Assert.AreEqual(pop, expected);
        }

    }
}

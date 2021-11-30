using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
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
    class NotificationsSteps
    {
        [Given(@"I selects See All hyperlink in the Notification on Profile page")]
        public void GivenISelectsSeeAllHyperlinkInTheNotificationOnProfilePage()
        {
            //Instantiate Action Class        
            Actions actions = new Actions(Driver.driver);
            //Retrieve WebElement 'Notifications' to perform mouse hover 
            IWebElement menuOption = Driver.driver.FindElement(By.XPath("//div[@class='ui top left pointing dropdown item']"));
            //Mouse hover menuOption 'Notifications'
            actions.MoveToElement(menuOption).Perform();
            Thread.Sleep(2000);
            //Now Select 'See All' from sub menu which has got displayed on mouse hover of 'Notifications'
            IWebElement selectMenuOption = Driver.driver.FindElement(By.XPath("//div[@class='ui link item']//a[@href='/Account/Dashboard']"));
            //Mouse hover menuOption 'See All'
            actions.MoveToElement(selectMenuOption).Perform();
            selectMenuOption.Click();
        }

        [When(@"I clicks on Load More botton if notifications are more than (.*)")]
        public void WhenIClicksOnLoadMoreBottonIfNotificationsAreMoreThan(int p0)
        {
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath(Notification_XPath.LoadMore_Xpath)).Click();
        }

        [Then(@"I can see all the notifications in a page")]
        public void ThenICanSeeAllTheNotificationsInAPage()
        {
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath(Notification_XPath.Noti_Xpath)).Click();
        }


        [Given(@"I select See All hyperlink in the Notification on Profile page")]
        public void GivenISelectSeeAllHyperlinkInTheNotificationOnProfilePage()
        {
            //Instantiate Action Class        
            Actions actions = new Actions(Driver.driver);
            //Retrieve WebElement 'Notifications' to perform mouse hover 
            IWebElement menuOption = Driver.driver.FindElement(By.XPath("//div[@class='ui top left pointing dropdown item']"));
            //Mouse hover menuOption 'Notifications'
            actions.MoveToElement(menuOption).Perform();
            Thread.Sleep(2000);
            //Now Select 'See All' from sub menu which has got displayed on mouse hover of 'Notifications'
            IWebElement selectMenuOption = Driver.driver.FindElement(By.XPath("//div[@class='ui link item']//a[@href='/Account/Dashboard']"));
            //Mouse hover menuOption 'See All'
            actions.MoveToElement(selectMenuOption).Perform();
            selectMenuOption.Click();
        }

        [Given(@"I clicks on Load More botton if notifications are more than (.*)")]
        public void GivenIClicksOnLoadMoreBottonIfNotificationsAreMoreThan(int p0)
        {
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath(Notification_XPath.LoadMore_Xpath)).Click();
        }

        [When(@"I clicks on Show less button to show less notifications")]
        public void WhenIClicksOnShowLessButtonToShowLessNotifications()
        {
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath(Notification_XPath.ShowLess_Xpath)).Click();
        }

        [Then(@"I can see less notifications in a page")]
        public void ThenICanSeeLessNotificationsInAPage()
        {
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath(Notification_XPath.Noti_Xpath)).Click();
        }

        [When(@"I select See All hyperlink in the Notification on Profile page")]
        public void WhenISelectSeeAllHyperlinkInTheNotificationOnProfilePage()
        {
            //Instantiate Action Class        
            Actions actions = new Actions(Driver.driver);
            //Retrieve WebElement 'Notifications' to perform mouse hover 
            IWebElement menuOption = Driver.driver.FindElement(By.XPath("//div[@class='ui top left pointing dropdown item']"));
            //Mouse hover menuOption 'Notifications'
            actions.MoveToElement(menuOption).Perform();
            Thread.Sleep(2000);
            //Now Select 'See All' from sub menu which has got displayed on mouse hover of 'Notifications'
            IWebElement selectMenuOption = Driver.driver.FindElement(By.XPath("//div[@class='ui link item']//a[@href='/Account/Dashboard']"));
            //Mouse hover menuOption 'See All'
            actions.MoveToElement(selectMenuOption).Perform();
            selectMenuOption.Click();
        }

        [Then(@"I select the Select All button")]
        public void ThenISelectTheSelectAllButton()
        {
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath(Notification_XPath.SelectAll_Xpath)).Click();
        }

        [When(@"I select the Select All button")]
        public void WhenISelectTheSelectAllButton()
        {
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath(Notification_XPath.SelectAll_Xpath)).Click();
        }

        [Then(@"I select the Unselect buttin")]
        public void ThenISelectTheUnselectButtin()
        {
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath(Notification_XPath.Unselect_Xpath)).Click();
        }

        [Given(@"I select the Select All button")]
        public void GivenISelectTheSelectAllButton()
        {
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath(Notification_XPath.SelectAll_Xpath)).Click();
        }

        [When(@"I select the Mark selection as read button")]
        public void WhenISelectTheMarkSelectionAsReadButton()
        {
            Driver.driver.FindElement(By.XPath(Notification_XPath.Mark_Xpath)).Click();
        }

        [Then(@"The selected notification should be marked to do actions")]
        public void ThenTheSelectedNotificationShouldBeMarkedToDoActions()
        {
            string pop = Driver.driver.FindElement(By.XPath(Notification_XPath.PopUp_Xpath)).Text;
            string expected = "Notification updated";
            Assert.AreEqual(pop, expected);
        }

        [Given(@"I select the checkbox for a particular notification to be deleted")]
        public void GivenISelectTheCheckboxForAParticularNotificationToBeDeleted()
        {
            Driver.driver.FindElement(By.XPath(Notification_XPath.Check_Xpath)).Click();
        }

        [When(@"I seller selects the delete icon")]
        public void WhenISellerSelectsTheDeleteIcon()
        {
            Driver.driver.FindElement(By.XPath(Notification_XPath.Delete_Xpath)).Click();
        }

        [Then(@"The selected notification should be deleted")]
        public void ThenTheSelectedNotificationShouldBeDeleted()
        {
            string pop = Driver.driver.FindElement(By.XPath(Notification_XPath.PopUp_Xpath)).Text;
            string expected = "Notification updated";
            Assert.AreEqual(pop, expected);
        }

    }
}

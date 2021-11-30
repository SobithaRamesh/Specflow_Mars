using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using MarsQA_1.SpecflowPages.Pages;
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
    class ChatSteps
    {
        [Given(@"I enters the skill in the Profile Page")]
        public void GivenIEntersTheSkillInTheProfilePage()
        {
            Driver.driver.FindElement(By.XPath(SearchSkill_XPath.SearchSkillTB_Xpath)).SendKeys("AutoIt");
        }

        [Given(@"I clicks Search button")]
        public void GivenIClicksSearchButton()
        {
            Driver.driver.FindElement(By.XPath(SearchSkill_XPath.SearchBtn_Xpath)).Click();
        }

        [Given(@"I select a particular seller from the list to chat with him/her")]
        public void GivenISelectAParticularSellerFromTheListToChatWithHimHer()
        {
            Driver.driver.FindElement(By.XPath(Chat_XPath.SellerSkill_Xpath)).Click();
        }

        [When(@"I click the chat button")]
        public void WhenIClickTheChatButton()
        {
            Driver.driver.FindElement(By.XPath(Chat_XPath.SellerChatBtn_Xpath)).Click();
            Thread.Sleep(1000);
        }

        [Then(@"I send the meassage to that seller")]
        public void ThenISendTheMeassageToThatSeller()
        {
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath(Chat_XPath.ChatTxtBox_Xpath)).SendKeys("Hi, I am interested in your Listing");
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath(Chat_XPath.ChatSend_Xpath)).Click();
            Thread.Sleep(1000);
        }

        [Given(@"I click in the Chat button in the Profile page")]
        public void GivenIClickInTheChatButtonInTheProfilePage()
        {
            Driver.driver.FindElement(By.XPath(Chat_XPath.ChatBtn_Xpath)).Click();
        }

        [Then(@"I click on the seller name on the left of the chat room")]
        public void ThenIClickOnTheSellerNameOnTheLeftOfTheChatRoom()
        {
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath(Chat_XPath.ChatName_Xpath)).Click();
        }

    }
}

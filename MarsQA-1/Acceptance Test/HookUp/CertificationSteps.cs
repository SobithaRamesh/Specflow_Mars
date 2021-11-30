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

namespace MarsQA_1.HookUp
{
    [Binding]
    class Certification
    {
        [Given(@"I selects the Certification tab in profile page")]
        public void GivenISelectsTheCertificationTabInProfilePage()
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.CertificationsTab_XPath)).Click();
        }

        [Given(@"I click AddNew button")]
        public void GivenIClickAddNewButton()
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.CertiAddNewBtn_XPath)).Click();
        }

        [Given(@"I enters (.*) and (.*) and (.*)")]
        public void GivenIEntersAndAnd(string Certi, string From, string Year)
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.AddCertificationTextBox_XPath)).SendKeys(Certi);
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath(XPathHelper.CertifiedFromTextBox_XPath)).SendKeys(From);
            Thread.Sleep(1000);
            SelectElement LevelSelect = new SelectElement(Driver.driver.FindElement(By.XPath(XPathHelper.YearofCertificationDropdown_XPath)));
            LevelSelect.SelectByValue(Year);
        }

        [When(@"I click Add button")]
        public void WhenIClickAddButton()
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.CertiAddBtn_XPath)).Click();
        }

        [Then(@"The details of (.*) should be successfully added")]
        public void ThenTheDetailsOfShouldBeSuccessfullyAdded(string Certi)
        {
            Thread.Sleep(1000);
            String msg = Driver.driver.FindElement(By.XPath("//td[normalize-space()='AWS Certification']")).Text;
            Assert.AreEqual(Certi, msg);
        }

        [Given(@"I click update icon")]
        public void GivenIClickUpdateIcon()
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.CertiUpdateIcon_Xpath)).Click();
        }

        [Given(@"I updates (.*) and (.*) and (.*)")]
        public void GivenIUpdatesAndAnd(string CertiUpdate, string FromUpdate, string YearUpdate)
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.AddCertificationTextBox_XPath)).Clear();
            Driver.driver.FindElement(By.XPath(XPathHelper.AddCertificationTextBox_XPath)).SendKeys(CertiUpdate);
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath(XPathHelper.CertifiedFromTextBox_XPath)).Clear();
            Driver.driver.FindElement(By.XPath(XPathHelper.CertifiedFromTextBox_XPath)).SendKeys(FromUpdate);
            Thread.Sleep(1000);
            SelectElement LevelSelect = new SelectElement(Driver.driver.FindElement(By.XPath(XPathHelper.YearofCertificationDropdown_XPath)));
            LevelSelect.SelectByValue(YearUpdate);
        }

        [When(@"I click Update button")]
        public void WhenIClickUpdateButton()
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.CertiUpdateBtn_Xpath)).Click();
        }

        [Then(@"The details of (.*) should be successfully updated")]
        public void ThenTheDetailsOfShouldBeSuccessfullyUpdated(string CertiUpdate)
        {
            Thread.Sleep(1000);
            string pop = Driver.driver.FindElement(By.XPath(Notification_XPath.PopUp_Xpath)).Text;
            string expected = "Certification in Animation has been updated to your certification";
            Assert.AreEqual(pop, expected);
        }

        [When(@"I click delete icon")]
        public void WhenIClickDeleteIcon()
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.CertiDeleteIcon_Xpath)).Click();
        }

        [Then(@"The details of (.*) should be successfully deleted")]
        public void ThenTheDetailsOfShouldBeSuccessfullyDeleted(string CertiDel)
        {
            Thread.Sleep(1000);
            string pop = Driver.driver.FindElement(By.XPath(Notification_XPath.PopUp_Xpath)).Text;
            string expected = "Certification in Animation has been deleted from your certification";
            Assert.AreEqual(pop, expected);
        }

    }      

}
    
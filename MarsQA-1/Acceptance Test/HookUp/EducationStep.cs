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
    class EducationStep
    {
        [Given(@"I Selects the Education tab in profile page")]
        public void GivenISelectsTheEducationTabInProfilePage()
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.EduTab_XPath)).Click();
        }

        [Given(@"I Clicks AddNew button")]
        public void GivenIClicksAddNewButton()
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.EduAddNewBtn_XPath)).Click();
        }

        [Given(@"I Enters (.*) and (.*) and (.*) and (.*) and (.*)")]
        public void GivenIEntersAndAndAndAnd(string CName, string Country, string Title, string Degree, string Year)
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.UniTextBox_Xpath)).SendKeys(CName);
            Thread.Sleep(1000);
            SelectElement CountrySelect = new SelectElement(Driver.driver.FindElement(By.XPath(XPathHelper.CtryTextBox_Xpath)));
            CountrySelect.SelectByValue(Country);
            Thread.Sleep(1000);
            SelectElement TitleSelect = new SelectElement(Driver.driver.FindElement(By.XPath(XPathHelper.TitleTextBox_Xpath)));
            TitleSelect.SelectByValue(Title);
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath(XPathHelper.DegreeTextBox_Xpath)).SendKeys(Degree);
            Thread.Sleep(1000);
            SelectElement YearSelect = new SelectElement(Driver.driver.FindElement(By.XPath(XPathHelper.YearTextBox_Xpath)));
            YearSelect.SelectByValue(Year);
            Thread.Sleep(1000);
        }

        [When(@"Select clicks Add button")]
        public void WhenSelectClicksAddButton()
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.EduAddBtn_XPath)).Click();
        }

        [Then(@"The details of (.*) should be added")]
        public void ThenTheDetailsOfShouldBeAdded(string Title)
        {
            Thread.Sleep(1000);
            String msg = Driver.driver.FindElement(By.XPath("//div[@data-tab='third']//div[@class='form-wrapper']//table//tr//td[3]")).Text;
            Assert.AreEqual(Title, msg);
        }

        [Given(@"I Clicks update icon")]
        public void GivenIClicksUpdateIcon()
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.EduUpdateIcon_Xpath)).Click();
        }

        [Given(@"I Updates (.*) and (.*) and (.*) and (.*) and (.*)")]
        public void GivenIUpdatesAndAndAndAnd(string CNameUp, string CountryUp, string TitleUp, string DegreeUp, string YearUp)
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.UniTextBox_Xpath)).Clear();
            Driver.driver.FindElement(By.XPath(XPathHelper.UniTextBox_Xpath)).SendKeys(CNameUp);
            Thread.Sleep(1000);
            //Driver.driver.FindElement(By.XPath(XPathHelper.CtryTextBox_Xpath)).Clear();
            SelectElement CountrySelect = new SelectElement(Driver.driver.FindElement(By.XPath(XPathHelper.CtryUpdate_Xpath)));
            CountrySelect.SelectByValue(CountryUp);
            Thread.Sleep(1000);
            SelectElement TitleSelect = new SelectElement(Driver.driver.FindElement(By.XPath(XPathHelper.TitleUpdate_Xpath)));
            TitleSelect.SelectByValue(TitleUp);
            Thread.Sleep(1000);
            Driver.driver.FindElement(By.XPath(XPathHelper.DegreeTextBox_Xpath)).Clear();
            Driver.driver.FindElement(By.XPath(XPathHelper.DegreeTextBox_Xpath)).SendKeys(DegreeUp);
            Thread.Sleep(1000);
            SelectElement YearSelect = new SelectElement(Driver.driver.FindElement(By.XPath(XPathHelper.YearTextBox_Xpath)));
            YearSelect.SelectByValue(YearUp);
            Thread.Sleep(1000);
        }

        [When(@"I Clicks Update button")]
        public void WhenIClicksUpdateButton()
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.EduUpdateBtn_Xpath)).Click();
        }

        [Then(@"The details of (.*) should be updated")]
        public void ThenTheDetailsOfShouldBeUpdated(string TitleUp)
        {
            Thread.Sleep(1000);
            String msg = Driver.driver.FindElement(By.XPath("//div[@data-tab='third']//div[@class='form-wrapper']//table//tr//td[3]")).Text;
            Assert.AreEqual(TitleUp, msg);
        }

        [When(@"I Click delete icon")]
        public void WhenIClickDeleteIcon()
        {
            Driver.driver.FindElement(By.XPath(XPathHelper.EduDeleteIcon_Xpath)).Click();
        }

        [Then(@"The details of (.*) should be deleted")]
        public void ThenTheDetailsOfShouldBeDeleted(string TitleDel)
        {
            Thread.Sleep(1000);
            string pop = Driver.driver.FindElement(By.XPath(Notification_XPath.PopUp_Xpath)).Text;
            string expected = "Education entry successfullu removed";
            Assert.AreEqual(pop, expected);
        }


    }
}

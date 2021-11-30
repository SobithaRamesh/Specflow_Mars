using AutoItX3Lib;
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

namespace MarsQA_1.SpecflowPages.Pages
{
    class ShareSkill
    {
        private IWebElement ShareSkillBtnTab() => Driver.driver.FindElement(By.XPath(XPathHelper.ShareSkillBtn_Xpath));
        private IWebElement Title() => Driver.driver.FindElement(By.XPath(XPathHelper.Title_Xpath));
        private IWebElement Description() => Driver.driver.FindElement(By.XPath(XPathHelper.Desc_Xpath));
        private IWebElement Category() => Driver.driver.FindElement(By.XPath(XPathHelper.Category_Xpath));
        private IWebElement SubCategory() => Driver.driver.FindElement(By.XPath(XPathHelper.SubCategory_Xpath));
        private IWebElement Tags() => Driver.driver.FindElement(By.XPath(XPathHelper.Tags_Xpath));
        private IWebElement HourlyBasis() => Driver.driver.FindElement(By.XPath(XPathHelper.HourlyBasisService_Xpath));
        private IWebElement OneOffService() => Driver.driver.FindElement(By.XPath(XPathHelper.OneoffService_Xpath));
        private IWebElement Onsite() => Driver.driver.FindElement(By.XPath(XPathHelper.Onsite_Xpath));
        private IWebElement Online() => Driver.driver.FindElement(By.XPath(XPathHelper.Online_Xpath));
        private IWebElement StartDate() => Driver.driver.FindElement(By.XPath(XPathHelper.StartDate_Xpath));
        private IWebElement EndDate() => Driver.driver.FindElement(By.XPath(XPathHelper.EndDate_Xpath));
        private IWebElement Days() => Driver.driver.FindElement(By.XPath(XPathHelper.Days_Xpath));
        private IWebElement StartTime() => Driver.driver.FindElement(By.XPath(XPathHelper.StartTime_Xpath));
        private IWebElement EndTime() => Driver.driver.FindElement(By.XPath(XPathHelper.EndTime_Xpath));
        private IWebElement SkillExchange() => Driver.driver.FindElement(By.XPath(XPathHelper.SkillExchange_Xpath));
        private IWebElement SkillExchangeTag() => Driver.driver.FindElement(By.XPath(XPathHelper.SkillExchangeTag_Xpath));
        private IWebElement Credit() => Driver.driver.FindElement(By.XPath(XPathHelper.Credit_Xpath));
        private IWebElement CreditAmount() => Driver.driver.FindElement(By.XPath(XPathHelper.CreditAmt_Xpath));
        private IWebElement WorkSamples() => Driver.driver.FindElement(By.XPath(XPathHelper.WorkSamples_Xpath));
        private IWebElement Active() => Driver.driver.FindElement(By.XPath(XPathHelper.Active_Xpath));
        private IWebElement Hidden() => Driver.driver.FindElement(By.XPath(XPathHelper.Hidden_Xpath));
        private IWebElement SaveBtn() => Driver.driver.FindElement(By.XPath(XPathHelper.Save_Xpath));
        private IWebElement CancelBtn() => Driver.driver.FindElement(By.XPath(XPathHelper.Cancel_Xpath));

        private IWebElement Category_ML() => Driver.driver.FindElement(By.XPath(ManageListing_XPath.Category_Xpath));
        private IWebElement Title_ML() => Driver.driver.FindElement(By.XPath(ManageListing_XPath.Title_Xpath));
    
    public void EnterShareSkill()
        {

            Thread.Sleep(3000);

            // Sheet Name of the excel file
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ShareSkillExcelPath, ConstantHelpers.AddingShareSkill);

            // Read the Title from excel and enter it in the title input
            Title().SendKeys(ExcelLibHelper.ReadData(2, "Title"));
                        
            // Read the Description from excel and enter it in the description input
            Description().SendKeys(ExcelLibHelper.ReadData(2, "Description"));

            // Read the Category from excel and select it from the category dropdown 
            SelectElement category = new SelectElement(Category());
            category.SelectByText(ExcelLibHelper.ReadData(2, "Category"));

            // Read the Subcategory from excel and select it from the subcategory dropdown 
            SelectElement subcategory = new SelectElement(SubCategory());
            subcategory.SelectByText(ExcelLibHelper.ReadData(2, "Subcategory"));

            // Read the Tags from excel and enter it in the Tags input 
            Tags().SendKeys(ExcelLibHelper.ReadData(2, "Tags"));
            Tags().SendKeys(Keys.Return);
            Thread.Sleep(500);

            //Read the ServiceType from excel and select the type 
            if (ExcelLibHelper.ReadData(2, "ServiceType") == "Hourly basis service")
            {
                HourlyBasis().Click();
            }
            else
            {
                OneOffService().Click();
            }

            //Read the LocationType from excel and select the type 
            if (ExcelLibHelper.ReadData(2, "LocationType") == "On-site")
            {
                Onsite().Click();
            }
            else
            {
                Online().Click();
            }

            //Read the StartDate from excel and select the startdate 
            StartDate().SendKeys(ExcelLibHelper.ReadData(2, "StartDate"));

            //Read the EndDate from excel and select the enddate
            EndDate().SendKeys(ExcelLibHelper.ReadData(2, "EndDate"));

            //Select the Available Days
            Days().Click();

            //Read StartTime from excel and send the data
            StartTime().SendKeys(ExcelLibHelper.ReadData(2, "StartTime"));

            //Read EndTime from excel and send the data
            EndTime().SendKeys(ExcelLibHelper.ReadData(2, "EndTime"));
            Thread.Sleep(1000);

            if (ExcelLibHelper.ReadData(2, "SkillTrade") == "Skill-exchange")
            {
                SkillExchange().Click();
                SkillExchangeTag().SendKeys(ExcelLibHelper.ReadData(2, "SkillExchange"));
                SkillExchangeTag().SendKeys(Keys.Return);
            }
            else if (ExcelLibHelper.ReadData(2, "SkillTrade") == "Credit")
            {
                Credit().Click();
                CreditAmount().SendKeys(ExcelLibHelper.ReadData(2, "Credit"));
                Credit().SendKeys(Keys.Enter);
            }
            Thread.Sleep(500);

            // Click on the WorkSample "+" Button
            WorkSamples().Click();
            Thread.Sleep(3000);

            // Upload file using autoit
            AutoItX3 autoitedit = new AutoItX3();
            // Activate- so that next set of actions happen on this window window
            autoitedit.WinActivate("file upload");
            Thread.Sleep(3000);
            // Path
            autoitedit.Send(ExcelLibHelper.ReadData(2, "Sample"));
            Thread.Sleep(2000);
            // Pressing Open button
            
             autoitedit.Send("{Enter}");
            Thread.Sleep(3000);

            //Read the ActiveType from excel and select the type 
            if (ExcelLibHelper.ReadData(2, "Active") == "Active")
            {
                Active().Click();
            }
            else
            {
                Hidden().Click();
            }

            SaveBtn().Click();


        }

        public void ValidateAddedShareSkill()
        {
            Thread.Sleep(1000);
            if (Category_ML().Text == ExcelLibHelper.ReadData(2, "Category") && Title_ML().Text == ExcelLibHelper.ReadData(2, "Title"))
            {
                Thread.Sleep(1000);
                Assert.Pass();
                
            }
            else
            {
                Assert.Fail();
               
            }
            Thread.Sleep(2000);
        }

        public void EditShareSkill()
        {

            Thread.Sleep(3000);

            // Sheet Name of the excel file
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ShareSkillExcelPath, ConstantHelpers.AddingShareSkill);

            Title().Clear();
            // Read the Title from excel and enter it in the title input
            Title().SendKeys(ExcelLibHelper.ReadData(6, "Title"));

            Description().Clear();
            // Read the Description from excel and enter it in the description input
            Description().SendKeys(ExcelLibHelper.ReadData(6, "Description"));

            // Read the Category from excel and select it from the category dropdown 
            SelectElement category = new SelectElement(Category());
            category.SelectByText(ExcelLibHelper.ReadData(6, "Category"));

            // Read the Subcategory from excel and select it from the subcategory dropdown 
            SelectElement subcategory = new SelectElement(SubCategory());
            subcategory.SelectByText(ExcelLibHelper.ReadData(6, "Subcategory"));

            // Read the Tags from excel and enter it in the Tags input 
            Tags().SendKeys(ExcelLibHelper.ReadData(6, "Tags"));
            Tags().SendKeys(Keys.Return);
            Thread.Sleep(500);

            //Read the ServiceType from excel and select the type 
            if (ExcelLibHelper.ReadData(6, "ServiceType") == "Hourly basis service")
            {
                HourlyBasis().Click();
            }
            else
            {
                OneOffService().Click();
            }

            //Read the LocationType from excel and select the type 
            if (ExcelLibHelper.ReadData(6, "LocationType") == "On-site")
            {
                Onsite().Click();
            }
            else
            {
                Online().Click();
            }

            //Read the StartDate from excel and select the startdate 
            StartDate().SendKeys(ExcelLibHelper.ReadData(6, "StartDate"));

            //Read the EndDate from excel and select the enddate
            EndDate().SendKeys(ExcelLibHelper.ReadData(6, "EndDate"));

            //Select the Available Days
            Days().Click();

            //Read StartTime from excel and send the data
            StartTime().SendKeys(ExcelLibHelper.ReadData(6, "StartTime"));

            //Read EndTime from excel and send the data
            EndTime().SendKeys(ExcelLibHelper.ReadData(6, "EndTime"));
            Thread.Sleep(1000);

            if (ExcelLibHelper.ReadData(6, "SkillTrade") == "Skill-exchange")
            {
                SkillExchange().Click();
                SkillExchangeTag().SendKeys(ExcelLibHelper.ReadData(6, "SkillExchange"));
                SkillExchangeTag().SendKeys(Keys.Return);
            }
            else if (ExcelLibHelper.ReadData(6, "SkillTrade") == "Credit")
            {
                Credit().Click();
                CreditAmount().SendKeys(ExcelLibHelper.ReadData(6, "Credit"));
                Credit().SendKeys(Keys.Enter);
            }
            Thread.Sleep(500);

            // Click on the WorkSample "+" Button
            WorkSamples().Click();
            Thread.Sleep(3000);

            // Upload file using autoit
            AutoItX3 autoitedit = new AutoItX3();
            // Activate- so that next set of actions happen on this window window
            autoitedit.WinActivate("file upload");
            Thread.Sleep(3000);
            // Path
            autoitedit.Send(ExcelLibHelper.ReadData(6, "Sample"));
            Thread.Sleep(2000);
            // Pressing Open button

            autoitedit.Send("{Enter}");
            Thread.Sleep(3000);

            //Read the ActiveType from excel and select the type 
            if (ExcelLibHelper.ReadData(6, "Active") == "Active")
            {
                Active().Click();
            }
            else
            {
                Hidden().Click();
            }

            SaveBtn().Click();


        }

    }
}

using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class ManageListing
    {
        private IWebElement ML_Tab() => Driver.driver.FindElement(By.XPath(ManageListing_XPath.ML_Tab_Xpath));
        private IWebElement Category_ML() => Driver.driver.FindElement(By.XPath(ManageListing_XPath.Category_Xpath));
        private IWebElement Title_ML() => Driver.driver.FindElement(By.XPath(ManageListing_XPath.Title_Xpath));
        private IWebElement Edit_ML() => Driver.driver.FindElement(By.XPath(ManageListing_XPath.Edit_Xpath));
        private IWebElement Delete_ML() => Driver.driver.FindElement(By.XPath(ManageListing_XPath.Delete_Xpath));
        private IWebElement YesAction() => Driver.driver.FindElement(By.XPath(ManageListing_XPath.YES));
        private IWebElement NoAction() => Driver.driver.FindElement(By.XPath(ManageListing_XPath.NO));

        internal void EditManageListing()
        {
            Thread.Sleep(1000);
            ML_Tab().Click();
            Thread.Sleep(1000);
            Edit_ML().Click();
            Thread.Sleep(1000);

            ShareSkill editSkillobj = new ShareSkill();
            editSkillobj.EditShareSkill();
        }
        internal void ValidateEdit()
        {
            if (Category_ML().Text == ExcelLibHelper.ReadData(6, "Category") && Title_ML().Text == ExcelLibHelper.ReadData(6, "Title"))
            {
                Assert.Pass();
            }
            else
            {
                Assert.Fail();
            }
            Thread.Sleep(2000);
        }

        internal void DeleteManageListing()
        {
            ExcelLibHelper.PopulateInCollection(ConstantHelpers.ShareSkillExcelPath, ConstantHelpers.ManageListingDel);

            if(ExcelLibHelper.ReadData(2, "DeleteAction") == "Yes")
            {
                YesAction().Click();
            }
            else
            {
                NoAction().Click();
            }
        }

    }
}

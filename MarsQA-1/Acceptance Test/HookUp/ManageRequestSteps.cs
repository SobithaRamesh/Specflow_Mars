using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using MarsQA_1.SpecflowPages.Pages;
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
    class ManageRequestSteps
    {

        [Given(@"I selects Recieved Requests from Manage Requests Tab")]
        public void GivenISelectsRecievedRequestsFromManageRequestsTab()
        {
            //Instantiate Action Class        
            Actions actions = new Actions(Driver.driver);
            //Retrieve WebElement 'Manage Requests' to perform mouse hover 
            IWebElement menuOption = Driver.driver.FindElement(By.XPath("(//div[@class='ui dropdown link item'])[1]"));
            //Mouse hover menuOption 'Manage Requests'
            actions.MoveToElement(menuOption).Perform();
            Thread.Sleep(2000);
            //Now Select 'Recieved Requests' from sub menu which has got displayed on mouse hover of 'Manage Requests'
            IWebElement selectMenuOption = Driver.driver.FindElement(By.XPath("//div[@class='menu transition hidden']//a[1]"));
            //Mouse hover menuOption 'Recieved Requests'
            actions.MoveToElement(selectMenuOption).Perform();
            selectMenuOption.Click();
        }

      
        [Then(@"I can be able to see the recieved requests")]
        public void ThenICanBeAbleToSeeTheRecievedRequests()
        {
            ManageRequests Recieved = new ManageRequests();
            Recieved.ValidRecievedReq();
        }

        [Given(@"I selects Sent Requests from Manage Requests Tab")]
        public void GivenISelectsSentRequestsFromManageRequestsTab()
        {
            //Instantiate Action Class        
            Actions actions = new Actions(Driver.driver);
            //Retrieve WebElement 'Manage Requests' to perform mouse hover
            IWebElement menuOption = Driver.driver.FindElement(By.XPath("(//div[@class='ui dropdown link item'])[1]"));
            //Mouse hover menuOption 'Manage Requests'
            actions.MoveToElement(menuOption).Perform();
            Thread.Sleep(2000);
            //Now Select 'Recieved Requests' from sub menu which has got displayed on mouse hover of 'Manage Requests'
            IWebElement selectMenuOption = Driver.driver.FindElement(By.XPath("//div[@class='menu transition hidden']//a[2]"));
            //Mouse hover menuOption 'Recieved Requests'
            actions.MoveToElement(selectMenuOption).Perform();
            selectMenuOption.Click();
        }

        [Then(@"I can be able to see the requests sent by the seller")]
        public void ThenICanBeAbleToSeeTheRequestsSentByTheSeller()
        {
            ManageRequests Recieved = new ManageRequests();
            Recieved.ValidSentReq();
        }

    }
}

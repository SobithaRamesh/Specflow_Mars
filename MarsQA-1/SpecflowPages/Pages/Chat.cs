using MarsQA_1.Helpers;
using MarsQA_1.SpecflowPages.Helpers;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class Chat
    {
        private IWebElement ChatSend() => Driver.driver.FindElement(By.XPath(Chat_XPath.ChatSend_Xpath));

       
    }
}

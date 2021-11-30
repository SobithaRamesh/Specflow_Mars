using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Helpers
{
    class Chat_XPath
    {
        public static string ChatBtn_Xpath = "//div[@class='ui compact menu']//a[@class='item'][@href='/Home/Message']";

        public static string Chat_Xpath = "//div[@class='ui container marginBottom']//h3";

        public static string ChatName_Xpath = "//div[@class='ui divided items']//div[@class='item']//div[@class='content']//div[@class='header']";

        public static string ChatSend_Xpath = "//div[@class='ui action input']//button[@class='ui blue button'][1]";

        public static string SellerSkill_Xpath = "//div[@class='content']//a[@class='service-info']//p";

        public static string SellerChatBtn_Xpath = "//div[@class='row-padded']//a[@class='ui teal button']";

        public static string ChatTxtBox_Xpath = "//input[@class='ui fluid']";
    }
}

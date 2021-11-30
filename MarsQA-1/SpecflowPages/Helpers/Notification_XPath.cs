using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Helpers
{
    class Notification_XPath
    {
        public static string LoadMore_Xpath = "//div[@class='ui link item']//a[@class='ui button']";

        public static string Noti_Xpath = "//a[@class='item']//h1";

        public static string ShowLess_Xpath = "//div//a[@class='ui button']";

        public static string SelectAll_Xpath = "//div[@class='ui icon basic button']";

        public static string Unselect_Xpath = "//div[@class='ui icon basic button button-icon-style']";

        public static string Delete_Xpath = "//div[@data-tooltip='Delete selection']";

        public static string Check_Xpath = "//input[@type='checkbox'][@value='1']";

        public static string Mark_Xpath = "//div[@data-tooltip='Mark selection as read']";

        public static string PopUp_Xpath = "//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']";
    }

}

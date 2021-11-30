using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Helpers
{
    class ManageListing_XPath
    {
        public static string ML_Tab_Xpath = "//div[@class='ui eight item menu']//a[3]";

        public static string Category_Xpath = "//tbody//tr[1]//td[2][@class='one wide']";

        public static string Title_Xpath = "//tbody//tr[1]//td[3][@class='four wide']";

        public static string Edit_Xpath = "//tr[1]//td[8]//i[@class='outline write icon'][1]";

        public static string Delete_Xpath = "//tr[1]//td[8]//i[@class='remove icon'][1]";

        public static string YES = "//button[@class='ui icon positive right labeled button']";

        public static string NO = "//button[@class='ui negative button']";



    }
}

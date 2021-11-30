using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Helpers
{
    class SearchSkill_XPath
    {
        public static string SearchSkillTB_Xpath = "//div[@class='ui small icon input search-box']//input";

        public static string SearchBtn_Xpath = "//div[@class='ui small icon input search-box']//i";

        public static string Result_Xpath = "//div[@class='four wide column']//div//h3";

        public static string Category_Xpath = "//div[@class='ui link list']//a[7]";

        public static string SubCategory_Xpath = "//div[@class='ui link list']//a[@class='item subcategory'][4]";
    }
}

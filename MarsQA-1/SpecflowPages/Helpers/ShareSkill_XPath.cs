using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Helpers
{
    class ShareSkill_XPath
    {
        public static string ShareSkillBtn_Xpath = "//a[normalize-space()='Share Skill']";

        public static string Title_Xpath = "//div[@class='field  ']//input[@name='title']";

        public static string Desc_Xpath = "//div[@class='field  ']//textarea[@name='description']";

        public static string Category_Xpath = "//div[@class='five wide field']//select[@name='categoryId']";

        public static string SubCategory_Xpath = "//div[@class='five wide field']//select[@name='subcategoryId']";

        public static string Tags_Xpath = "(//input[contains(@aria-label,'Add new tag')])[1]"; 

        public static string HourlyBasisService_Xpath = "//div[@class='ui radio checkbox']//input[@name='serviceType'][@value='0']";

        public static string OneoffService_Xpath = "//div[@class='ui radio checkbox']//input[@name='serviceType'][@value='0']";

        public static string Onsite_Xpath = "//div[@class='ui radio checkbox']//input[@name='locationType'][@value='0']";

        public static string Online_Xpath = "//div[@class='ui radio checkbox']//input[@name='locationType'][@value='1']";

        public static string StartDate_Xpath = "//input[@name='startDate']";

        public static string EndDate_Xpath = "//input[@name='endDate']";

        public static string Days_Xpath = "//div[@class='ui checkbox']//input[@index='1']";
        
        public static string StartTime_Xpath = "//div[3]/div[2]/input[1]";

        public static string EndTime_Xpath = "//div[3]/div[3]/input[1]";

        public static string SkillExchange_Xpath = "//div[@class='ui radio checkbox']//input[@name='skillTrades'][@value='true']";

        public static string Credit_Xpath = "//div[@class='ui radio checkbox']//input[@name='skillTrades'][@value='false']";

        public static string CreditAmt_Xpath = "//input[@name='charge']";

        public static string WorkSamples_Xpath = "//div[@class='ui grid']//i[@class='huge plus circle icon padding-25']";

        public static string Active_Xpath = "//div[@class='ui radio checkbox']//input[@name='isActive'][@value='true']";

        public static string Hidden_Xpath = "//div[@class='ui radio checkbox']//input[@name='isActive'][@value='false']";

        public static string Save_Xpath = "//input[@value='Save']";

        public static string Cancel_Xpath = "//input[@value='Cancel']";

        
    }
}

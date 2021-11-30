using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Helpers
{
    class ProfileDetails_XPath
    {
        public static string Availability = "(//i[@class='right floated outline small write icon'])[1]";

        public static string Hours = "(//i[@class='right floated outline small write icon'])[2]";

        public static string EarnTarget = "(//i[@class='right floated outline small write icon'])[3]";

        public static string Avail_Dropdown = "//div[@class='extra content']//div[2]//div[1]";

        public static string Avail_FullTime = "//option[@value='1']";

        public static string Hours_Dropdown = "//div[@class='extra content']//div[3]//div[1]//span[1]//select[1]";

        public static string Hours_Check = "//span[normalize-space()='Less than 30hours a week']";

        public static string Hours_list = "//option[@value='0'][normalize-space()='Less than 30hours a week']";

        public static string Earn_Dropdown = "//div[4]//div[1]//span[1]//select[1]";

        public static string Earn_List = "//option[@value='2'][normalize-space()='More than $1000 per month']";

        public static string Earn_Check = "//span[normalize-space()='More than $1000 per month']";

        public static string Description = "//h3[normalize-space()='Description']//i";

        public static string Desc_TextBox = "//div[@class='field  ']//textarea[@name='value']";

        public static string Desc_Save = "//button[@type='button']";

        public static string Desc_Check = "//div[@class='content']//div//span[@style='padding-top: 1em;']";
    }
}

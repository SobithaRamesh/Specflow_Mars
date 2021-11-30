using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Helpers
{
    class XPathHelper
    {

        //LanguageTab XPath
        public static string LangTab_XPath = "//a[@data-tab='first']";

        //Lang AddNew Button XPath
        public static string LangAddNewBtn_XPath = "(//div[contains(@class,'ui teal button')][normalize-space()='Add New'])[1]";

        //Lang Add Button XPath
        public static string LangAddBtn_XPath = "//input[@class='ui teal button'][@value='Add'][1]";

        //AddLang TextBox XPath
        public static string AddLangTextBox_Xpath = "//div[@class='five wide field']//input[@type='text']";

        //LangLevel Dropdown XPath
        public static string LangLevelDropdown_XPath = "//select[@class='ui dropdown']";
        //Lang Update Button XPath
        public static string LangUpdateBtn_Xpath = "//input[@value='Update']";


        public static String LangUpdateIcon_XPath = "//td[@class='right aligned']//i[@class='outline write icon']";


        public static string LangDeleteIcon_XPath = "//i[@class='remove icon']";

        public static String CertificationsTab_XPath = "//a[@data-tab='fourth']";

        //Certification TextBox XPath
        public static String AddCertificationTextBox_XPath = "//input[@placeholder='Certificate or Award']";

        //CertifiedFrom TextBox XPath
        public static String CertifiedFromTextBox_XPath = "//input[@placeholder='Certified From (e.g. Adobe)']";

        //Year of Certification XPath
        public static String YearofCertificationDropdown_XPath = "//select[@name='certificationYear']";

        //Certification AddNew Button XPath
        public static String CertiAddNewBtn_XPath = "//div[@id='account-profile-section']/div/section[2]//table/thead/tr/th[4]/div";

        //Certification Add Button XPath
        public static String CertiAddBtn_XPath = "//input[@value='Add']";

        //Certification Update Button XPath
        public static string CertiUpdateBtn_Xpath = "//input[@value='Update']";


        public static string CertiUpdateIcon_Xpath = "(//i[@class='outline write icon'])[3]";


        public static string CertiDeleteIcon_Xpath = "(//i[@class='remove icon'])[2]";

        //SkillTab XPath
        public static string SkillTab_XPath = "//a[@data-tab='second']";

        //Skill AddNew Button XPath
        public static string AddNewBtn_XPath = "//div[@class='ui teal button'][text()='Add New']";

        //Skill Add Button XPath
        public static string AddBtn_XPath = "//input[@value='Add'][1]";

        //AddSkill TextBox XPath
        public static string AddSkillTextBox_Xpath = "//input[@placeholder='Add Skill'][@type='text']";

        //SkillLevel Dropdown XPath
        public static string SkillLevelDropdown_XPath = "//select[@class='ui fluid dropdown'][1]";

        //Update Button XPath
        public static string UpdateBtn_Xpath = "//input[@value='Update']";

        public static string UpdateIcon_Xpath = "//div[@data-tab='second']//td[3]//i[@class='outline write icon']";


        public static string DeleteIcon_Xpath = "//div[@data-tab='second']//td[3]//i[@class='remove icon']";

        //EducationTab XPath
        public static string EduTab_XPath = "//a[@data-tab='third']";

        //Education AddNew Button XPath
        public static string EduAddNewBtn_XPath = "//*[@id='account-profile-section']//div//section[2]//div//div//div//div[3]//form//div[4]//div//div[2]//div//table//thead//tr//th[6]//div";

        //University TextBox XPath
        public static string UniTextBox_Xpath = "//div[@class='ten wide field']//input";

        //Country TextBox XPath
        public static string CtryTextBox_Xpath = "//div[@class='six wide field']//select[@class='ui dropdown'][@name='country']";

        //Title TextBox XPath
        public static string TitleTextBox_Xpath = "//div[@class='six wide field']//select[@class='ui dropdown'][@name='title']";

        //Degree TextBox XPath
        public static string DegreeTextBox_Xpath = "//div[@class='six wide field']//input[@name='degree']";

        //Year TextBox XPath
        public static string YearTextBox_Xpath = "//div[@class='four wide field']//select[@name='yearOfGraduation']";

        //Education Add Button XPath
        public static string EduAddBtn_XPath = "//input[@value='Add'][1]";

        public static string EduUpdateIcon_Xpath = "//div[@data-tab='third']//td[6]//i[@class='outline write icon']";

        public static string EduUpdateBtn_Xpath = "//div[@class='sixteen wide field']//input[1]";

        public static string TitleUpdate_Xpath = "//div[@class='six wide field']//select[@class='ui fluid dropdown'][@name='title']";

        public static string CtryUpdate_Xpath = "//div[@class='six wide field']//select[@class='ui fluid dropdown'][@name='country'][1]";

        public static string EduDeleteIcon_Xpath = "//div[@data-tab='third']//td[6]//i[@class='remove icon']";

        //ShareSkill
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
       
        public static string SkillExchangeTag_Xpath = "(//input[contains(@aria-label,'Add new tag')])[2]";
       
        public static string Credit_Xpath = "//div[@class='ui radio checkbox']//input[@name='skillTrades'][@value='false']";

        public static string CreditAmt_Xpath = "//input[@name='charge']";

        public static string WorkSamples_Xpath = "//div[@class='ui grid']//i[@class='huge plus circle icon padding-25']";

        public static string Active_Xpath = "//div[@class='ui radio checkbox']//input[@name='isActive'][@value='true']";

        public static string Hidden_Xpath = "//div[@class='ui radio checkbox']//input[@name='isActive'][@value='false']";

        public static string Save_Xpath = "//input[@value='Save']";

        public static string Cancel_Xpath = "//input[@value='Cancel']";

        public static string PopUp_Xpath = "//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']";
    }

}

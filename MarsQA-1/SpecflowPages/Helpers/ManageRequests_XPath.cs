using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Helpers
{
    class ManageRequests_XPath
    {
        public static string ManageRequestsTab_Xpath = "(//div[@class='ui dropdown link item'])[1]";
        
        public static string RecievedRequest_Xpath = "//div[@class='menu transition hidden']//a[1]";
                
        public static string SentRequest_Xpath = "//div[@class='menu transition hidden']//a[2]";

        public static string RecievedTitle = "//div[@class='ui container']//h2";

        public static string SentTitle = "//div[@class='ui container']//h2";
    }
}

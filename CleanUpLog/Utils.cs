using System.Collections.Generic;
using System.Linq;

namespace StatGenerator
{
    public class Utils
    {
        public StatGenerator StatGenerator { get; } = new StatGenerator();

        public string RemoveParameters(string s)
        {
            if (s.Contains('?'))
            {
                s = s.Remove(s.IndexOf('?'));
                return s;
            }
            return s;
        }

        public bool Exclude(string s)
        {
            var listToExlude = new List<string> {"/sitecore/admin/"};

            foreach (var excluder in listToExlude)
                if (s.Contains(excluder))
                    return true;

            return false;
        }


        public bool IsComparable(string url)
        {
            var comparables = new List<string>
            {
                "/mps/local-office/approval/proposals/summary",
                "/mps/local-office/approval/contracts/summary",
                @"/mps/dealer/contracts/summary",
                @"/mps/dealer/contracts/summary",
                @"/mps/dealer/proposals/convert/summary",
                @"comparables.Add(/proposal/current/products-available",
                @"/dealer/proposals/convert/customer-information",
                @"/dealer/proposals/create/customer-information",
                @"/dealer/proposals/create/summary",
                @"/dealer/proposals/create/click-price",
                @"/dealer/proposals/create/products",
                @"/proposal/current/product/add-or-update",
                @"/dealer/proposals/create/description",
                @"/dealer/proposals/create/term-type",
                @"/dealer/proposals/summary",
                @"/dealer/proposals/convert/term-type",
                @"/proposal/current/click-price",
                @"/dealer/proposals/convert/products",
                @"/proposal/current/product-configuration/1",
                @"/dealer/proposals/convert/click-price",
                @"/dealer/contracts/awaiting-acceptance",
                @"/dealer/dashboard",
                @"/dealer/contracts/rejected",
                @"/dealer/proposals/in progress",
                @"/dealer/contracts/approved-proposals",
                @"/local-office/approval/proposals/awaiting-approval",
                @"/dealer/proposals/awaiting-approval",
                @"/proposal/current/product-selection-status",
                @"/dealer/proposals/approved",
                @"/local-office/approval/contracts/awaiting-acceptance",
                @"/local-office/approval/contracts/rejected",
                @"/local-office/approval/contracts/approved-proposals",
                @"/local-office/approval/proposals/approved",
                @"/local-office/approval/proposals",
                @"/local-office/approval/dashboard",
                @"/local-office/dashboard",
                @"/dealer",
                @"/js/datatables",
                @"/dealer/create-proposal",
                @"/dealer/contracts",
                @"/local-office/approval",
                @"/local-office/approval/contracts",
                @"/dealer/proposals",
                @"/handlebars/product-selection-status-no-items",
                @"/local-office",
                @"/sitecore/content/e-mail campaign/brother online/standard messages/self-service subscription/mps/notifications/proposal approved notification email",
                @"/dealer/proposals/create",
                @"/sitecore/content/e-mail campaign/brother online/standard messages/self-service subscription/mps/notifications/contract rejected notification email",
                @"/handlebars/product-selection-status-items",
                @"/handlebars/product-configuration / default",
                @"/handlebars/products-available-items",
                @"/handlebars/product-added-successfully",
                @"/sitecore/content/e-mail campaign/brother online/standard messages/self-service subscription/mps/notifications/proposal submitted notification email",
                @"/sitecore/content/e-mail campaign/brother online/standard messages/self-service subscription/mps/notifications/contract signed notification email"
            };


            if (comparables.Contains(url))
                return true;
            return false;
        }
    }
}
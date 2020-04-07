using EorzeanFisher.Settings;
using System;
using System.Collections.Generic;
using System.Text;

namespace EorzeanFisher.XivApi
{
    public class RequestFactory
    {
        static RequestFactory instance = null;

        public static RequestFactory getInstance()
        {
            if (instance == null)
                instance = new RequestFactory();
            return instance;
        }

        public string getUrlFromType(eRequest requestType, string id = ProfilSettings.ETHER_ID)
        {
            if(requestType == eRequest.FREE_COMPANY)
            {
                return getFreeCompanyRequest(id);
            }
            else if(requestType == eRequest.FREE_COMPANY_MEMBERS)
            {
                return getFreeCompanyMembersRequest(id);
            }
            else
            {
                return string.Empty;
            }
        }

        string getFreeCompanyRequest(string id)
        {
            string url = "https://xivapi.com/freecompany/" + id;
            return url;
        }

        string getFreeCompanyMembersRequest(string id)
        {
            string url = "https://xivapi.com/freecompany/" + id + "?data=FCM";
            return url;
        }
    }
}

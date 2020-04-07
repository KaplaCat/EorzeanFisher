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

        public string getUrlFromType(eRequest requestType, string id)
        {
            if(requestType == eRequest.FREE_COMPANY)
            {
                return getFreeCompanyRequest(id);
            }
            else
            {
                return string.Empty;
            }
        }

        string getFreeCompanyRequest(string id)
        {
            if(id == string.Empty)
            {
                id = ProfilSettings.ETHER_ID;
            }
            string url = "https://xivapi.com/freecompany/" + id + "?data=FCM";
            return url;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using App1.Service.Model;
using Newtonsoft.Json;

namespace App1.Service
{
    public class ViaCEPService
    {
        private static string AddressURL = "https://viacep.com.br/ws/{0}/json/";

        public static Address SearchAddressViaCEP(string cep)
        {
            string newAddressURL = string.Format(AddressURL, cep);
            WebClient wc = new WebClient();
            string Content = wc.DownloadString(newAddressURL);
            Address Add = JsonConvert.DeserializeObject<Address>(Content);

            return Add;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Net.Http.Headers;

namespace Contacts.MVC
{
    public static class GlobalVariables
    {
        public static HttpClient ContactsAPIClient = new HttpClient();

        static GlobalVariables()
        {   // We can now use this within the Contacts.MVC controllers
            // This tells the MVC app to point to the URL below, which is the API itself
            ContactsAPIClient.BaseAddress = new Uri("http://localhost:49908/api/");// set to API address (Contacts.API)
            ContactsAPIClient.DefaultRequestHeaders.Clear();
            ContactsAPIClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}
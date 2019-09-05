using Microsoft.VisualStudio.TestTools.UnitTesting;
using Contacts.MVC.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace Contacts.MVC.Controllers.Tests
{
    [TestClass()]
    public class SearchContactsControllerTests
    {
        [TestMethod()]
        public void SearchTest()
        {
            HttpResponseMessage response = GlobalVariables.ContactsAPIClient.GetAsync("SearchContacts/" + "Cameron Smith").Result;
            var Phrase = response.ReasonPhrase;
            Assert.AreEqual("OK", Phrase);
        }
    }
}
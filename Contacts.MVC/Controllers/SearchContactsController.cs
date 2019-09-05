using Contacts.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace Contacts.MVC.Controllers
{
    public class SearchContactsController : Controller
    {
        // GET: SearchContacts
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Search(string id)
        {
            HttpResponseMessage response = GlobalVariables.ContactsAPIClient.GetAsync("SearchContacts/" + id).Result;
            if (response.StatusCode.ToString() == "NotFound")
            {
                TempData["ErrorMessage"] = "No record found!";
                return RedirectToAction("index");
            }
            else
                return View(response.Content.ReadAsAsync<ContactsModel>().Result);
        }
    }
}
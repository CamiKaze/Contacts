using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Contacts.API.Models;

namespace Contacts.API.Controllers
{
    public class SearchContactsController : ApiController
    {
        private DBModel db = new DBModel();

        // GET: api/SearchContacts
        public IQueryable<tblContact> GettblContacts()
        {
            return db.tblContacts;
        }

        //GET: api/SearchContacts/5
        [ResponseType(typeof(tblContact))]
        public IHttpActionResult GettblContact(string id)
        {// Edit, Search
            var SearchName = db.tblContacts.Where(s => s.Name == id).FirstOrDefault<tblContact>();

            if (SearchName == null)
            {
                return BadRequest(ModelState);  //return NotFound();
            }

            return Ok(SearchName);
        }

        // PUT: api/SearchContacts/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PuttblContact(int id, tblContact tblContact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != tblContact.ContactID)
            {
                return BadRequest();
            }

            db.Entry(tblContact).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblContactExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/SearchContacts
        [ResponseType(typeof(tblContact))]
        public IHttpActionResult PosttblContact(tblContact tblContact)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.tblContacts.Add(tblContact);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = tblContact.ContactID }, tblContact);
        }

        // DELETE: api/SearchContacts/5
        [ResponseType(typeof(tblContact))]
        public IHttpActionResult DeletetblContact(int id)
        {
            tblContact tblContact = db.tblContacts.Find(id);
            if (tblContact == null)
            {
                return NotFound();
            }

            db.tblContacts.Remove(tblContact);
            db.SaveChanges();

            return Ok(tblContact);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool tblContactExists(int id)
        {
            return db.tblContacts.Count(e => e.ContactID == id) > 0;
        }
    }
}
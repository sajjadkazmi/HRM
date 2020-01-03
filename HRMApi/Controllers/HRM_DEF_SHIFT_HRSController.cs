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
using HRMApi.Models;

namespace HRMApi.Controllers
{
    public class HRM_DEF_SHIFT_HRSController : ApiController
    {
        private HRMEntities db = new HRMEntities();

        // GET: api/HRM_DEF_SHIFT_HRS
        public IQueryable<HRM_DEF_SHIFT_HRS> GetHRM_DEF_SHIFT_HRS()
        {
            return db.HRM_DEF_SHIFT_HRS;
        }

        // GET: api/HRM_DEF_SHIFT_HRS/5
        [ResponseType(typeof(HRM_DEF_SHIFT_HRS))]
        public IHttpActionResult GetHRM_DEF_SHIFT_HRS(int id)
        {
            HRM_DEF_SHIFT_HRS hRM_DEF_SHIFT_HRS = db.HRM_DEF_SHIFT_HRS.Find(id);
            if (hRM_DEF_SHIFT_HRS == null)
            {
                return NotFound();
            }

            return Ok(hRM_DEF_SHIFT_HRS);
        }

        // PUT: api/HRM_DEF_SHIFT_HRS/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHRM_DEF_SHIFT_HRS(int id, HRM_DEF_SHIFT_HRS hRM_DEF_SHIFT_HRS)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != hRM_DEF_SHIFT_HRS.CODE)
            {
                return BadRequest();
            }

            db.Entry(hRM_DEF_SHIFT_HRS).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HRM_DEF_SHIFT_HRSExists(id))
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

        // POST: api/HRM_DEF_SHIFT_HRS
        [ResponseType(typeof(HRM_DEF_SHIFT_HRS))]
        public IHttpActionResult PostHRM_DEF_SHIFT_HRS(HRM_DEF_SHIFT_HRS hRM_DEF_SHIFT_HRS)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.HRM_DEF_SHIFT_HRS.Add(hRM_DEF_SHIFT_HRS);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = hRM_DEF_SHIFT_HRS.CODE }, hRM_DEF_SHIFT_HRS);
        }

        // DELETE: api/HRM_DEF_SHIFT_HRS/5
        [ResponseType(typeof(HRM_DEF_SHIFT_HRS))]
        public IHttpActionResult DeleteHRM_DEF_SHIFT_HRS(int id)
        {
            HRM_DEF_SHIFT_HRS hRM_DEF_SHIFT_HRS = db.HRM_DEF_SHIFT_HRS.Find(id);
            if (hRM_DEF_SHIFT_HRS == null)
            {
                return NotFound();
            }

            db.HRM_DEF_SHIFT_HRS.Remove(hRM_DEF_SHIFT_HRS);
            db.SaveChanges();

            return Ok(hRM_DEF_SHIFT_HRS);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HRM_DEF_SHIFT_HRSExists(int id)
        {
            return db.HRM_DEF_SHIFT_HRS.Count(e => e.CODE == id) > 0;
        }
    }
}
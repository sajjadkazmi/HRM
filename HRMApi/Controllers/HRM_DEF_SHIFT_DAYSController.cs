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
    public class HRM_DEF_SHIFT_DAYSController : ApiController
    {
        private HRMEntities db = new HRMEntities();

        // GET: api/HRM_DEF_SHIFT_DAYS
        public IQueryable<HRM_DEF_SHIFT_DAYS> GetHRM_DEF_SHIFT_DAYS()
        {
            return db.HRM_DEF_SHIFT_DAYS;
        }

        // GET: api/HRM_DEF_SHIFT_DAYS/5
        [ResponseType(typeof(HRM_DEF_SHIFT_DAYS))]
        public IHttpActionResult GetHRM_DEF_SHIFT_DAYS(int id)
        {
            HRM_DEF_SHIFT_DAYS hRM_DEF_SHIFT_DAYS = db.HRM_DEF_SHIFT_DAYS.Find(id);
            if (hRM_DEF_SHIFT_DAYS == null)
            {
                return NotFound();
            }

            return Ok(hRM_DEF_SHIFT_DAYS);
        }

        // PUT: api/HRM_DEF_SHIFT_DAYS/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHRM_DEF_SHIFT_DAYS(int id, HRM_DEF_SHIFT_DAYS hRM_DEF_SHIFT_DAYS)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            if (id != hRM_DEF_SHIFT_DAYS.CODE)
            {
                return BadRequest();
            }

            db.Entry(hRM_DEF_SHIFT_DAYS).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HRM_DEF_SHIFT_DAYSExists(id))
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

        // POST: api/HRM_DEF_SHIFT_DAYS
        [ResponseType(typeof(HRM_DEF_SHIFT_DAYS))]
        public IHttpActionResult PostHRM_DEF_SHIFT_DAYS(HRM_DEF_SHIFT_DAYS hRM_DEF_SHIFT_DAYS)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            db.HRM_DEF_SHIFT_DAYS.Add(hRM_DEF_SHIFT_DAYS);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = hRM_DEF_SHIFT_DAYS.CODE }, hRM_DEF_SHIFT_DAYS);
        }

        // DELETE: api/HRM_DEF_SHIFT_DAYS/5
        [ResponseType(typeof(HRM_DEF_SHIFT_DAYS))]
        public IHttpActionResult DeleteHRM_DEF_SHIFT_DAYS(int id)
        {
            HRM_DEF_SHIFT_DAYS hRM_DEF_SHIFT_DAYS = db.HRM_DEF_SHIFT_DAYS.Find(id);
            if (hRM_DEF_SHIFT_DAYS == null)
            {
                return NotFound();
            }

            db.HRM_DEF_SHIFT_DAYS.Remove(hRM_DEF_SHIFT_DAYS);
            db.SaveChanges();

            return Ok(hRM_DEF_SHIFT_DAYS);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HRM_DEF_SHIFT_DAYSExists(int id)
        {
            return db.HRM_DEF_SHIFT_DAYS.Count(e => e.CODE == id) > 0;
        }
    }
}
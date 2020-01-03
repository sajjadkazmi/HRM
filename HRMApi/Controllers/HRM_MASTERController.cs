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
    public class HRM_MASTERController : ApiController
    {
        private HRMEntities db = new HRMEntities();

        // GET: api/HRM_MASTER
        public IQueryable<HRM_MASTER> GetHRM_MASTER()
        {
            return db.HRM_MASTER;
        }

        // GET: api/HRM_MASTER/5
        [ResponseType(typeof(HRM_MASTER))]
        public IHttpActionResult GetHRM_MASTER(decimal id)
        {
            HRM_MASTER hRM_MASTER = db.HRM_MASTER.Find(id);
            if (hRM_MASTER == null)
            {
                return NotFound();
            }

            return Ok(hRM_MASTER);
        }

        // PUT: api/HRM_MASTER/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHRM_MASTER(decimal id, HRM_MASTER hRM_MASTER)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            if (id != hRM_MASTER.USER_CODE)
            {
                return BadRequest();
            }

            db.Entry(hRM_MASTER).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HRM_MASTERExists(id))
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

        // POST: api/HRM_MASTER
        [ResponseType(typeof(HRM_MASTER))]
        public IHttpActionResult PostHRM_MASTER(HRM_MASTER hRM_MASTER)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            db.HRM_MASTER.Add(hRM_MASTER);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (HRM_MASTERExists(hRM_MASTER.USER_CODE))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = hRM_MASTER.USER_CODE }, hRM_MASTER);
        }

        // DELETE: api/HRM_MASTER/5
        [ResponseType(typeof(HRM_MASTER))]
        public IHttpActionResult DeleteHRM_MASTER(decimal id)
        {
            HRM_MASTER hRM_MASTER = db.HRM_MASTER.Find(id);
            if (hRM_MASTER == null)
            {
                return NotFound();
            }

            db.HRM_MASTER.Remove(hRM_MASTER);
            db.SaveChanges();

            return Ok(hRM_MASTER);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HRM_MASTERExists(decimal id)
        {
            return db.HRM_MASTER.Count(e => e.USER_CODE == id) > 0;
        }
    }
}
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
    public class HRM_DEF_SHIFT_TYPEController : ApiController
    {
        private HRMEntities db = new HRMEntities();

        // GET: api/HRM_DEF_SHIFT_TYPE
        public IQueryable<HRM_DEF_SHIFT_TYPE> GetHRM_DEF_SHIFT_TYPE()
        {
            return db.HRM_DEF_SHIFT_TYPE;
        }

        // GET: api/HRM_DEF_SHIFT_TYPE/5
        [ResponseType(typeof(HRM_DEF_SHIFT_TYPE))]
        public IHttpActionResult GetHRM_DEF_SHIFT_TYPE(int id)
        {
            HRM_DEF_SHIFT_TYPE hRM_DEF_SHIFT_TYPE = db.HRM_DEF_SHIFT_TYPE.Find(id);
            if (hRM_DEF_SHIFT_TYPE == null)
            {
                return NotFound();
            }

            return Ok(hRM_DEF_SHIFT_TYPE);
        }

        // PUT: api/HRM_DEF_SHIFT_TYPE/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutHRM_DEF_SHIFT_TYPE(int id, HRM_DEF_SHIFT_TYPE hRM_DEF_SHIFT_TYPE)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            if (id != hRM_DEF_SHIFT_TYPE.CODE)
            {
                return BadRequest();
            }

            db.Entry(hRM_DEF_SHIFT_TYPE).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!HRM_DEF_SHIFT_TYPEExists(id))
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

        // POST: api/HRM_DEF_SHIFT_TYPE
        [ResponseType(typeof(HRM_DEF_SHIFT_TYPE))]
        public IHttpActionResult PostHRM_DEF_SHIFT_TYPE(HRM_DEF_SHIFT_TYPE hRM_DEF_SHIFT_TYPE)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            db.HRM_DEF_SHIFT_TYPE.Add(hRM_DEF_SHIFT_TYPE);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = hRM_DEF_SHIFT_TYPE.CODE }, hRM_DEF_SHIFT_TYPE);
        }

        // DELETE: api/HRM_DEF_SHIFT_TYPE/5
        [ResponseType(typeof(HRM_DEF_SHIFT_TYPE))]
        public IHttpActionResult DeleteHRM_DEF_SHIFT_TYPE(int id)
        {
            HRM_DEF_SHIFT_TYPE hRM_DEF_SHIFT_TYPE = db.HRM_DEF_SHIFT_TYPE.Find(id);
            if (hRM_DEF_SHIFT_TYPE == null)
            {
                return NotFound();
            }

            db.HRM_DEF_SHIFT_TYPE.Remove(hRM_DEF_SHIFT_TYPE);
            db.SaveChanges();

            return Ok(hRM_DEF_SHIFT_TYPE);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool HRM_DEF_SHIFT_TYPEExists(int id)
        {
            return db.HRM_DEF_SHIFT_TYPE.Count(e => e.CODE == id) > 0;
        }
    }
}
using HRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace HRM.Controllers
{
    public class SHIFT_HRSController : Controller
    {
        // GET: SHIFT_HRS
        public ActionResult Index()
        {

            IEnumerable<HRM_DEF_SHIFT_HRS> ShiftTypeList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("HRM_DEF_SHIFT_HRS").Result;
            ShiftTypeList = response.Content.ReadAsAsync<IEnumerable<HRM_DEF_SHIFT_HRS>>().Result;
            return View(ShiftTypeList);
            //return View(ShiftTypeList);
        }

        public ActionResult AddOrEdit(int id = 0)
        {
            //Binding Dropdowns
            IEnumerable<view_HRM_DEF_SHIFT_TYPE> ShiftType;
            HttpResponseMessage res = GlobalVariables.WebApiClient.GetAsync("HRM_DEF_SHIFT_TYPE").Result;
            ShiftType = res.Content.ReadAsAsync<IEnumerable<view_HRM_DEF_SHIFT_TYPE>>().Result;
            ViewBag.ShiftTypeList = new SelectList(ShiftType, "CODE", "DESC");

            if (id == 0)
                return View(new HRM_DEF_SHIFT_HRS());
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("HRM_DEF_SHIFT_HRS/" + id.ToString()).Result;
                //return View(response.Content.ReadAsAsync<IEnumerable<mvcEmployeeModel>>().Result);
                return View(response.Content.ReadAsAsync<HRM_DEF_SHIFT_HRS>().Result);
            }
        }
        [HttpPost]
        public ActionResult AddOrEdit(HRM_DEF_SHIFT_HRS car)
        {

            if (car.CODE == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("HRM_DEF_SHIFT_HRS", car).Result;

            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("HRM_DEF_SHIFT_HRS/" + car.CODE, car).Result;
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("HRM_DEF_SHIFT_HRS/" + id.ToString()).Result;
            return RedirectToAction("Index");
        }
    }
}
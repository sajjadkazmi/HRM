using HRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace HRM.Controllers
{
    public class HRM_DEF_SHIFT_TYPEController : Controller
    {
        // GET: HRM_DEF_SHIFT_TYPE
        public ActionResult Index()
        {

            IEnumerable<view_HRM_DEF_SHIFT_TYPE> ShiftTypeList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("HRM_DEF_SHIFT_TYPE").Result;
            ShiftTypeList = response.Content.ReadAsAsync<IEnumerable<view_HRM_DEF_SHIFT_TYPE>>().Result;
            return View(ShiftTypeList);
            //return View(ShiftTypeList);
        }

        public ActionResult AddOrEdit(int id = 0)
        {
            if (id == 0)
                return View(new view_HRM_DEF_SHIFT_TYPE());
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("HRM_DEF_SHIFT_TYPE/" + id.ToString()).Result;
                //return View(response.Content.ReadAsAsync<IEnumerable<mvcEmployeeModel>>().Result);
                return View(response.Content.ReadAsAsync<view_HRM_DEF_SHIFT_TYPE>().Result);
            }
        }
        [HttpPost]
        public ActionResult AddOrEdit(view_HRM_DEF_SHIFT_TYPE car)
        {

            if (car.CODE == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("HRM_DEF_SHIFT_TYPE", car).Result;

            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("HRM_DEF_SHIFT_TYPE/" + car.CODE, car).Result;
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("HRM_DEF_SHIFT_TYPE/" + id.ToString()).Result;
            return RedirectToAction("Index");
        }
    }
}
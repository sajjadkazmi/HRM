using HRM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace HRM.Controllers
{
    public class HRM_MASTERController : Controller
    {
        // GET: HRM_MASTER
        public ActionResult Index()
        {

            IEnumerable<HRM_MASTER> ShiftTypeList;
            HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("HRM_MASTER").Result;
            ShiftTypeList = response.Content.ReadAsAsync<IEnumerable<HRM_MASTER>>().Result;
            return View(ShiftTypeList);
            //return View(ShiftTypeList);
        }

        public ActionResult AddOrEdit(int id = 0)
        {
            //Binding Dropdowns
            //IEnumerable<HRM_DEF_SHIFT_HRS> ShiftHr;
            //HttpResponseMessage res = GlobalVariables.WebApiClient.GetAsync("HRM_DEF_SHIFT_HRS").Result;
            //ShiftHr = res.Content.ReadAsAsync<IEnumerable<HRM_DEF_SHIFT_HRS>>().Result;
            //ViewBag.ShiftHrList = new SelectList(ShiftHr, "CODE", "DESC");

            //IEnumerable<view_HRM_DEF_SHIFT_TYPE> ShiftType;
            //HttpResponseMessage ress = GlobalVariables.WebApiClient.GetAsync("HRM_DEF_SHIFT_TYPE").Result;
            //ShiftType = ress.Content.ReadAsAsync<IEnumerable<view_HRM_DEF_SHIFT_TYPE>>().Result;
            //ViewBag.ShiftTypeList = new SelectList(ShiftType, "CODE", "DESC");

            if (id == 0)
                return View(new HRM_MASTER());
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.GetAsync("HRM_MASTER/" + id.ToString()).Result;
                //return View(response.Content.ReadAsAsync<IEnumerable<mvcEmployeeModel>>().Result);
                return View(response.Content.ReadAsAsync<HRM_MASTER>().Result);
            }
        }
        [HttpPost]
        public ActionResult AddOrEdit(HRM_DEF_SHIFT_DAYS car)
        {

            if (car.CODE == 0)
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PostAsJsonAsync("HRM_MASTER", car).Result;

            }
            else
            {
                HttpResponseMessage response = GlobalVariables.WebApiClient.PutAsJsonAsync("HRM_MASTER/" + car.CODE, car).Result;
            }
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            HttpResponseMessage response = GlobalVariables.WebApiClient.DeleteAsync("HRM_MASTER/" + id.ToString()).Result;
            return RedirectToAction("Index");
        }
    }
}
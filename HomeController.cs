using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Day2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult NewEmployee()
        {
            List<SelectListItem> cities = new List<SelectListItem>();
            cities.Add(new SelectListItem { Text = "Select", Value = "" });
            cities.Add(new SelectListItem { Text = "BGL", Value = "BGL" });
            cities.Add(new SelectListItem { Text = "Chennai", Value = "Chennai" });
            ViewBag.cities = cities;
            return View();
        }

        [HttpPost]
        public ActionResult NewEmployee(string EmpName,string EmpCity,string EmpGender,HttpPostedFileBase EmpImg)
        {
            //Ado.net
            string address = "/Images/" + Guid.NewGuid() + ".jpg";
            EmpImg.SaveAs(Server.MapPath(address));
            ViewBag.address = address;
            ViewBag.msg = "Employee Added";

            List<SelectListItem> cities = new List<SelectListItem>();
            cities.Add(new SelectListItem { Text = "Select", Value = "" });
            cities.Add(new SelectListItem { Text = "BGL", Value = "BGL" });
            cities.Add(new SelectListItem { Text = "Chennai", Value = "Chennai" });
            ViewBag.cities = cities;

            ModelState.Clear();

            return View();
        }
        public ActionResult Index()
        {
            return View();
        }

    }
}
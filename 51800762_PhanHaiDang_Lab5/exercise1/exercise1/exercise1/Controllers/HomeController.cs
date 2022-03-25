using exercise1.Factory;
using exercise1.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace exercise1.Controllers
{
    public class HomeController : Controller
    {
        private static DatabaseFactory GetFactory()
        {
            var connStr = ConfigurationManager.ConnectionStrings["sqlconn"].ConnectionString;
            DatabaseFactory factory;

            if(LoadData.typeData == 1)
            {
                factory = new MySQLDbFactory();
            }
            else
            {
                factory = new SQLDbFactory();
            }
            return factory;
        }
        public ActionResult Index()
        {
            var ls = new SinhVienService(GetFactory()).getList();

            return View(ls);
        }

        public ActionResult SetID(int id)
        {
            LoadData.typeData = id;
            return View();
        }


        [HttpGet]
        public ActionResult EditSv(string id)
        {
            try
            {
                if (Regex.IsMatch(id, @"\d"))
                {
                    var sv = new SinhVienService(GetFactory()).getByID(Int32.Parse(id));
                    if(sv == null)
                    {
                        return Redirect("/");
                    }
                    return View(sv);
                }
                return Redirect("/");

            }
            catch(Exception e)
            {
                return Redirect("/");
            }
        }
        [HttpPost]
        public ActionResult EditSv(string id, Student student)
        {
            try
            {
                if (new SinhVienService(GetFactory()).Update(Int32.Parse(id), student))
                {
                    return Redirect("/");
                }
                return View(student);
            }
            catch (Exception e)
            {
                return Redirect("/");
            }
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpGet]
        public ActionResult AddSV()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSV(Student student)
        {
            if( new SinhVienService(GetFactory()).Add(student))
            {
                return Redirect("/");
            }
            return View(student);
        }

        [HttpPost]
        public JsonResult DeleteSv(int id)
        {
            try
            {
                if (new SinhVienService(GetFactory()).Delete(id))
                {
                    return Json(new { success = true, message = "Xóa sinh viên thành công" });
                }
                return Json(new { success = false, message = "Xóa sinh viên thất bại" });
            }
            catch(Exception e)
            {
                return Json(new { success = false, message = e.Message });
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication6.Models;

namespace WebApplication6.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            List<Person> list = new List<Person>();
            list.Add(new Person()
            {
                Email = "1@2.3",
                FirstName = "Ali",
                LastName = "Badri",
                Mobile = "09121234567"
            });
            list.Add(new Person()
            {
                Email = "5@6.7",
                FirstName = "Reza",
                LastName = "Badri",
                Mobile = "09385522552"
            });
            return View(list);
        }

        [HttpGet]
        public JsonResult CallBack()
        {
            var content = new JsonResult();
            content.JsonRequestBehavior = JsonRequestBehavior.AllowGet;
            content.Data = "Success";
            return content;
        }
    }
}
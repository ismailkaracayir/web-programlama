using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace YeniWebOdev.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            sevimlidostlar.BusinessLayer.Test test = new sevimlidostlar.BusinessLayer.Test();
            // test.insert_test();
            // test.Update_test();
            // test.Delete_test();
            test.Comment_test();
            return View();
        }
    }
}
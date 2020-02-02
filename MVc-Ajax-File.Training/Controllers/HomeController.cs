using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVc_Ajax_File.Training.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Upload()
        {
            return View();
        }

        public ActionResult FileUpload()
        {
            HttpPostedFileBase file = HttpContext.Request.Files[0];


            return Json("",JsonRequestBehavior.AllowGet);
        }
    }
}
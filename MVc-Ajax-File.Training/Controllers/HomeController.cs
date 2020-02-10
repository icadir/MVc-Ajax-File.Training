using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVc_Ajax_File.Training.Models;
using MVc_Ajax_File.Training.Utilities;
using WebGrease.Css.Extensions;

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

        public ActionResult fileView()
        {
            var List = context.Dosyas.ToList();
            return new FileContentResult(List[0].Deger, List[0].DosyaTipi);
        }
        GaleriEntities context = new GaleriEntities();
        public ActionResult FileUpload()
        {
            HttpPostedFileBase file = HttpContext.Request.Files[0];
            using (BinaryReader reader = new BinaryReader(file.InputStream))
            {
                byte[] value = reader.ReadBytes((Int32)file.ContentLength);
                if (Session["value"] == null)
                    Session["value"] = value;
                else
                    Session["value"] = UtilityManager.ByteBirlestir((byte[])Session["value"], value);

                if (10000 > file.ContentLength)
                {
                    context.Dosyas.Add(new Dosya
                    {
                        Deger = (byte[])Session["value"],
                        DosyaAdi = file.FileName,
                        DosyaBoyutu = ((byte[])Session["value"]).Length.ToString(),
                        DosyaTipi = file.ContentType,
                        KayitTarihi = DateTime.Now,
                    });
                    Session["value"] = null;
                }
            }



            return Json("", JsonRequestBehavior.AllowGet);
        }


    }
}
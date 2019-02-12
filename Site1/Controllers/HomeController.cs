using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DAL;
namespace Site1.Controllers
{
    public class HomeController : Controller
    {
        DAL.DBase ctx = new DAL.DBase();
        public ActionResult Index()
        {
            return View(ctx.Products);
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

        public ActionResult GoLink(string id)
        {
            if (String.IsNullOrEmpty(ctx.Products.FirstOrDefault(x => x.Name == id).URL))
                return HttpNotFound("URL NOT FOUND");

            else
                return Redirect(ctx.Products.FirstOrDefault(x => x.Name == id).URL);
        }
   
        public  ActionResult GetJson(string id)
        {
            if (ctx.Descriptions.FirstOrDefault(x => x.ID_Product == ctx.Products.FirstOrDefault(y => y.Name == id).ID) != null)
                return Json(ctx.Descriptions.FirstOrDefault(x => x.ID_Product == ctx.Products.FirstOrDefault(y => y.Name == id).ID), JsonRequestBehavior.AllowGet);
            else
                return Json("Descriptions not found", JsonRequestBehavior.AllowGet);
        }

    }
}
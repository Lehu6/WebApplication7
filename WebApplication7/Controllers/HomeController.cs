using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication7.Helpers;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class HomeController : Controller
    {
        protected override void ExecuteCore()
        {
            int culture = 0;
            if (this.Session == null || this.Session["CurrentCulture"] == null)
            {

                int.TryParse(System.Configuration.ConfigurationManager.AppSettings["Culture"], out culture);
                this.Session["CurrentCulture"] = culture;
            }
            else
            {
                culture = (int)this.Session["CurrentCulture"];
            }

            CultureHelper.CurrentCulture = culture;

            base.ExecuteCore();
        }


        public ActionResult ChangeCurrentCulture(int id)
        {

            CultureHelper.CurrentCulture = id;
            Session["CurrentCulture"] = id;

            return Redirect(Request.UrlReferrer.ToString());
        }


        public ActionResult Index()
        {
            return View(new MainModel());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact(MainModel model)
        {
            ViewBag.Message = "Your contact page.";

            return View(new MainModel());
        }

        [HttpPost, ActionName("Save")]
        public ActionResult Save([Bind(Include = "NickName,Email")] MainModel model)
        {
            if (ModelState.IsValid)
            {
                return View("Contact", model);
            }
            else
            {
                return View("Index");
            }
        }
    }
}
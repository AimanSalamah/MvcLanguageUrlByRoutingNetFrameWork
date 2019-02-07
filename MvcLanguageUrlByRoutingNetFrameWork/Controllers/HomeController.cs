using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcLanguageUrlByRoutingNetFrameWork.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var lang = (string)this.RouteData.Values["language"];
            switch ((string)this.RouteData.Values["language"])
            {
                case "ar-sa":
                    return View("indexar");
                case "en-sa":
                    return View("indexen");
                default:
                    return View("PageNotFound");
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
        public ActionResult ChangeLanguage(string Lang, string returnURL)
        {
            if (returnURL.Length > 1)
                return Redirect($"/{Lang}{returnURL.Substring(6, returnURL.Length - 6)}");
            else return Redirect(returnURL);
        }
    }
}
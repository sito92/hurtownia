using System.Web.Mvc;
using Hurtownia.Models;

namespace Hurtownia.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            var testConnection = new WholeSaleDbContext();
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Hurtownia";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}

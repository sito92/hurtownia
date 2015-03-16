using System.Web.Mvc;
using Hurtownia.Interfaces;
using Hurtownia.Models;

namespace Hurtownia.Controllers
{
    public class HomeController : Controller
    {
        private IUnitRepository unitRepository;

        public HomeController(IUnitRepository repository)
        {
            unitRepository = repository;
        }
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            unitRepository.GetUnitByName("kilo");

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

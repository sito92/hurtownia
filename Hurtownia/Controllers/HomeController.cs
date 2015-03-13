using System.Web.Mvc;
using Hurtownia.Models;

namespace Hurtownia.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            //using (WholeSaleDbContext context = new WholeSaleDbContext())
            //{
            //    context.PaymentTypes.Add(new PaymentType() {Type = "Karta"});
            //    context.SaveChanges();
            //}

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

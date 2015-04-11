using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hurtownia.Models;
using Hurtownia.Models.ViewModels;

namespace Hurtownia.Controllers
{
    public class OrderController : Controller
    {
        WholeSaleDbContext context = new WholeSaleDbContext();
        //
        // GET: /Order/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            
            return View(context.Orders);
        }

        private ViewResult OrderNotFound()
        {
            ViewBag.ErrorMessage = "Nie znalezniono zamówienia";
            return View("MyErrorView");
        }


        public ActionResult Details(int orderId = 0)
        {
            var order = context.Orders.FirstOrDefault(x => x.Id == orderId);

            if (order==null)
            {
                return OrderNotFound();

            }
            var productlists = context.ProductLists.ToList().FindAll(x=>x.OrderId==orderId);

            var productgroups = productlists.Select(pl => new ProductGroup() {Amount = pl.Amount, Product = pl.Product}).ToList();
            OrderDetailsViewModel viewModel = new OrderDetailsViewModel {ProductGroups = productgroups, Order = order};
            return View(viewModel);
        }

    }
}

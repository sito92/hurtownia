using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hurtownia.Models;
using Hurtownia.Repository;

namespace Hurtownia.Controllers
{
    public class CartController : Controller
    {
        //
        // GET: /Cart/
        ProductRepository productRepository = new ProductRepository();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Show()
        {
            if (Session["Cart"] == null)
            {
                Session["Cart"] = new Cart();
            }
            return View(Session["Cart"]);
        }

        public ActionResult AddProduct(int productId=0)
        {
            if (Session["Cart"]==null)
            {
                Session["Cart"] = new Cart();
            }
            if (productRepository.FindBy(x=>x.Id == productId) != null && productId >0)
            {
                ((Cart)Session["Cart"]).Products.Add(productRepository.FindBy(x=>x.Id == productId).FirstOrDefault());
            }
            else
            {
                TempData["message"] = "Produkt nie znaleziony";
            }
            return View("Show",Session["Cart"]);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hurtownia.Interfaces;
using Hurtownia.Models;
using Hurtownia.Models.ViewModels;

namespace Hurtownia.Controllers
{
    public class ProductController : Controller
    {
         private IProductRepository productRepository;

         public ProductController(IProductRepository repository)
        {
            productRepository = repository;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ViewResult List()
        {
            ProductsViewModel viewModel = new ProductsViewModel()
            {
                Products = productRepository.GetAll()
            };
            return View(viewModel);
        }

        public ViewResult Edit(int id=1)
        {
            Product product = productRepository.GetProductById(id);
            return product!=null ? View(product) : ProductNotFound();
        }
        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                productRepository.Save(product);
                TempData["message"] = "Produkt pomyślnie edytowany";
                return RedirectToAction("List");
            }
            else
            {
                return View(product);
            }
        }
        private ViewResult ProductNotFound()
        {
            ViewBag.ErrorMessage = "Nie znalezniono produktu";
            return View("MyErrorView");
        }

        public ViewResult Details(int id = 1)
        {
            Product product = productRepository.GetProductById(id);
            return product != null ? View(product) : ProductNotFound();
        }
     
        

    }
}

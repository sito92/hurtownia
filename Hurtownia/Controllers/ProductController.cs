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
            if (product!=null)
            {
                return View(product); 
            }
            else
            {
                ViewBag.ErrorMessage = "Nie znalezniono produktu";
                return View("MyErrorView"); 
            }

        }

    }
}

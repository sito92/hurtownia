using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.Mvc;
using Hurtownia.Interfaces;
using Hurtownia.Models;
using Hurtownia.Models.ViewModels;
using Microsoft.Ajax.Utilities;

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

        public ViewResult List(ProductsViewModel viewModel)
        
        {
            
            viewModel.Products = productRepository.GetAll();

                viewModel.FilterProduct = viewModel.FilterProduct ?? new FilterProduct();
                viewModel.Products = viewModel.Products.Where(x => x.Amount == (viewModel.FilterProduct.Ammount ?? x.Amount));
                viewModel.Products = viewModel.Products.Where(x => x.Name == (viewModel.FilterProduct.Name ?? x.Name));
                viewModel.Products = viewModel.Products.Where(x => x.Price >= (viewModel.FilterProduct.MinPrice ?? x.Price));
                viewModel.Products = viewModel.Products.Where(x => x.Price <= (viewModel.FilterProduct.MaxPrice ?? x.Price));
                viewModel.Products = viewModel.Products.Where(x => x.ProductType.Name == (viewModel.FilterProduct.ProductType.Name ?? x.ProductType.Name));
                   
            ViewBag.ProductTypes = productRepository.GetAll().Select(x => x.ProductType).Distinct();
                
            return View(viewModel);
        }
        public ViewResult Details(int id = 1)
        {
            Product product = productRepository.GetProductById(id);
            return product != null ? View(product) : ProductNotFound();
        }
     
        

    }
}

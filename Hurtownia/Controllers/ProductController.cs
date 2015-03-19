using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.Mvc;
using Hurtownia.Interfaces;
using Hurtownia.Models;
using Hurtownia.Models.ViewModels;
using Hurtownia.Repository;
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

        public ViewResult Test()
        {

           // ProductRepository repo = new ProductRepository();
            WholeSaleDbContext context = new WholeSaleDbContext();

            var products = context.Products.AsEnumerable();

            products = products.Where(x => x.ProductType.Name == "warzywo");
            return View(products);
        }
        public ViewResult List(ProductsViewModel viewModel)
        
        {

            
           // viewModel.Products = productRepository.GetAll();

                viewModel.FilterProduct = viewModel.FilterProduct ?? new FilterProduct();
                viewModel.Products = productRepository.GetAll().Where(x => x.Amount == (viewModel.FilterProduct.Ammount ?? x.Amount))
                .Where(x => x.Name == (viewModel.FilterProduct.Name ?? x.Name))
                .Where(x => x.Price >= (viewModel.FilterProduct.MinPrice ?? x.Price))
                .Where(x => x.Price <= (viewModel.FilterProduct.MaxPrice ?? x.Price))
                .Where(x => x.ProductType.Name == "owoc");


            ViewBag.ProductTypes = productRepository.GetAll().Select(x => x.ProductType).Select(x => x.Name);
                
            return View(viewModel);
        }
        public ViewResult Details(int id = 1)
        {
            Product product = productRepository.GetProductById(id);
            return product != null ? View(product) : ProductNotFound();
        }
     
        

    }
}

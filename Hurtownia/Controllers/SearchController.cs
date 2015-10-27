using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hurtownia.Interfaces;
using Hurtownia.Models;
using System.Reflection;
using Hurtownia.Models.ViewModels;
using Microsoft.Ajax.Utilities;

namespace Hurtownia.Controllers
{
    public class SearchController : Controller
    {
        private IProductRepository _iProductRepository;

        public SearchController(IProductRepository iProductRepository)
        {
            _iProductRepository = iProductRepository;
        }

        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Search(Product product)
        {
            return View();
        }
        [HttpPost]
        public ActionResult SearchProducts(FilterProduct model)
        {
            ProductsViewModel viewModel = new ProductsViewModel()
            {
                FilterProduct = model,

            };
            viewModel.Products = _iProductRepository.GetAllProducts();

            if (model.Ammount!=null)
            {
                viewModel.Products = viewModel.Products.Where(x => x.Amount == model.Ammount);
            }

            return RedirectToAction("List", "Product");
        }
    }
}

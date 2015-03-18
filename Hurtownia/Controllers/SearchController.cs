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
        {/*
            var ab = product.GetType().GetProperties(); // pozyskanie propercji klasy produkt

            var dict = new Dictionary<PropertyInfo, Func<object, List<Product>>>(); // słownik przypisujący każdej propercji określoną metodę

            var methodsToInvoke = new List<Func<object, List<Product>>>(); // lista metod do wykonania

            dict.Add(ab[0],_iProductRepository.GetProductByProductType); //przykład

            foreach (var prop in product.GetType().GetProperties())
            {
                var a = prop.GetValue(product, new object[] {});

                if (a != null)
                {
                    methodsToInvoke.Add(dict[prop]); //dodanie odpowiednich metod do zbioru tych, które powinny się wykonać
                }
            }

            //no i tu jakoś wywołać wszystkie metody z methodsToInvoke
            */
            return View();
        }
        [HttpPost]
        public ActionResult SearchProducts(FilterProduct model)
        {
            ProductsViewModel viewModel = new ProductsViewModel()
            {
                FilterProduct = model,

            };
            viewModel.Products = _iProductRepository.GetAll();

            if (model.Ammount!=null)
            {
                viewModel.Products = viewModel.Products.Where(x => x.Amount == model.Ammount);
            }

            return RedirectToAction("List", "Product");
        }


    }
}

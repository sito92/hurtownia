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

        public ViewResult Add()
        {
     
            PopulateProductTypes();
            PopulateUnits();
            return View();
        }

        [HttpPost]
        public ActionResult Add(Product model)
        {
            if (ModelState.IsValid)
            {
                productRepository.Save(model);
                TempData["message"] = "Produkt pomyślnie dodany";
                return RedirectToAction("List");
            }
            else
            {
                return View(model);
            }
        }
        public ViewResult Edit(int id=1)
        {
            
            Product product = productRepository.GetProductById(id);
            PopulateProductTypes(product.ProductTypeID);
            PopulateUnits(product.UnitId);
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
            viewModel.Products = productRepository.GetAllProducts();
            if (viewModel.FilterProduct.IsFiltering)
            {
                viewModel.Products = viewModel.Products
                    .Where(x => x.Amount == (viewModel.FilterProduct.Ammount ?? x.Amount))
                    .Where(x => x.Name == (viewModel.FilterProduct.Name ?? x.Name))
                    .Where(x => x.Price >= (viewModel.FilterProduct.MinPrice ?? x.Price))
                    .Where(x => x.Price <= (viewModel.FilterProduct.MaxPrice ?? x.Price))
                    .Where(x => x.ProductTypeID == (viewModel.FilterProduct.ProductTypeId == 0 ? x.ProductTypeID : viewModel.FilterProduct.ProductTypeId))
                    .Where(x => x.UnitId == (viewModel.FilterProduct.UnitId == 0 ? x.UnitId : viewModel.FilterProduct.UnitId));

            }

            PopulateProductTypes(viewModel.FilterProduct.ProductTypeId);
            PopulateUnits(viewModel.FilterProduct.UnitId);
            return View(viewModel);
        }
        public ViewResult Details(int id = 1)
        {
            Product product = productRepository.GetProductById(id);
            return product != null ? View(product) : ProductNotFound();
        }

        private void  PopulateProductTypes(object selectedType =  null)
        {
            var typesList = productRepository.GetAllProducts().Select(x => x.ProductType).OrderBy(x => x.Name).Distinct().ToList();
            typesList.Insert(0,new ProductType(){Id = 0,Name = "Wszystkie"});
            ViewBag.ProductTypes = new SelectList(typesList, "Id", "Name", selectedType??0);

        }

        private void PopulateUnits(object selectedUnit = null)
        {
            var unitList = productRepository.GetAllProducts().Select(x => x.Unit).OrderBy(x => x.Name).Distinct().ToList();
            unitList.Insert(0, new Unit() {Id = 0,Name = "Wszystkie"});
            ViewBag.Units = new SelectList(unitList, "Id", "Name", selectedUnit ?? 0);

        }
       


    }
}


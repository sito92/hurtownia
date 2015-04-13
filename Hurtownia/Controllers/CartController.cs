using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DotNetOpenAuth.OpenId.Extensions.AttributeExchange;
using Hurtownia.Models;
using Hurtownia.Models.ViewModels;
using Hurtownia.Repository;

namespace Hurtownia.Controllers
{
    public class CartController : Controller
    {
        //
        // GET: /Cart/
        ProductRepository productRepository = new ProductRepository();
        WholeSaleDbContext dbContext = new WholeSaleDbContext();
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

        public ActionResult AddProduct(int productId = 0)
        {
            if (Session["Cart"] == null)
            {
                Session["Cart"] = new Cart();
            }
            if (productRepository.FindBy(x => x.Id == productId) != null && productId > 0)
            {
                ((Cart)Session["Cart"]).Add(productRepository.FindBy(x => x.Id == productId).FirstOrDefault());
            }
            else
            {
                TempData["message"] = "Produkt nie znaleziony";
            }
            return View("Show", Session["Cart"]);
        }

        public ActionResult CheckOut()
        {
            if (Session["Cart"] != null)
            {
                var viewModel = new CheckOutViewModel { Cart = (Cart)Session["Cart"] };
                PopulatePaymentTypes();
                PopulateEmplyees();
                PopulateClients();
                return View(viewModel);
            }

            return View("CheckoutError");
        }
        [HttpPost]
        public ActionResult CheckOut(CheckOutViewModel viewModel)
        {
            viewModel.Cart = (Cart)Session["Cart"];
            viewModel.Order.Client = dbContext.Clients.ToList().Find(x => x.Id == viewModel.Order.ClientId);

            List<ProductList> productLists = new List<ProductList>();

            foreach (var prgr in viewModel.Cart.Products)
            {
                productLists.Add(new ProductList() { Amount = prgr.Amount, Order = viewModel.Order, ProductId = prgr.Product.Id });
            }

            dbContext.ProductLists.AddRange(productLists);
            dbContext.SaveChanges();
            return View("OrderSummary", viewModel);
        }

        public void PopulatePaymentTypes(object selectedType = null)
        {
            var paymentTypesList = dbContext.PaymentTypes.Distinct().ToList();
            paymentTypesList.Insert(0, new PaymentType() { Id = 0, Type = "Wszystkie" });
            ViewBag.PaymentTypes = new SelectList(paymentTypesList, "Id", "Type", selectedType ?? 0);
        }
        public void PopulateClients(object selectedType = null)
        {
            var clientsList = dbContext.Clients.Distinct().ToList();
            clientsList.Insert(0, new Client() { Id = 0, Name = "Wszystkie" });
            ViewBag.Clients = new SelectList(clientsList, "Id", "Name", selectedType ?? 0);
        }
        public void PopulateEmplyees(object selectedType = null)
        {
            var employeesList = dbContext.Employees.Distinct().ToList();
            employeesList.Insert(0, new Employee() { Id = 0, Name = "Wszystkie" });
            ViewBag.Employees = new SelectList(employeesList, "Id", "Name", selectedType ?? 0);
        }
    }
}

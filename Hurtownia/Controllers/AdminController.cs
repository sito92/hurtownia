using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hurtownia.Interfaces;
using Hurtownia.Models.ViewModels;

namespace Hurtownia.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IProductRepository productRepository;

        public AdminController(IProductRepository repository)
        {
            productRepository = repository;
        }
        //
        // GET: /Admin/

        public ActionResult Index()
        {
            return View();
        }


    }
}

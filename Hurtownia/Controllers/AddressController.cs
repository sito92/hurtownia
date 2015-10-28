using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hurtownia.Models;

namespace Hurtownia.Controllers
{
    public class AddressController : Controller
    {
        private WholeSaleDbContext context;

        public AddressController()
        {
            context = new WholeSaleDbContext();
        }

        public ActionResult Details(int id)
        {
            var address = context.Addresses.FirstOrDefault(x => x.Id == id);

            if (address == null)
            {
                return HttpNotFound();
            }

            return View(address);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hurtownia.Models;

namespace Hurtownia.Controllers
{
    public class ClientController : Controller
    {
        //
        // GET: /Client/


        WholeSaleDbContext context = new WholeSaleDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult List()
        {
            return View(context.Clients);
        }

        public ActionResult Edit(int id)
        {
            var client = context.Clients.FirstOrDefault(x => x.Id == id);
            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);

        }

        [HttpPost]
        public ActionResult Edit(Client client)
        {
            if (ModelState.IsValid)
            {


                var preclient = context.Clients.FirstOrDefault(x => x.Id == client.Id);
                if (preclient == null)
                {
                    return HttpNotFound();
                }
                preclient.ClientType = client.ClientType;
                preclient.CompanyName = client.CompanyName;
                preclient.EMail = client.EMail;
                preclient.NIP = client.NIP;
                preclient.Name = client.Name;
                preclient.Surname = client.Surname;
                preclient.TelephoneNumber = client.Surname;
                context.SaveChanges();
            }
            return RedirectToAction("List");

        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Client client)
        {
            if (!ModelState.IsValid) return View();
            client.AddressId = 7;
            context.Clients.Add(client);
            context.SaveChanges();
            return RedirectToAction("List");
        }
    }
}

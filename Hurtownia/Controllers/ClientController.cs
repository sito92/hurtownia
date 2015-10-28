using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hurtownia.Models;
using Hurtownia.Models.ViewModels;
using Hurtownia.Repository;

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
            var clientViewModel = new ClientViewModel();
            clientViewModel.Clients = context.Clients;

            return View(clientViewModel);
        }

        public ActionResult Details(int id = 1)
        {
            var client = context.Clients.FirstOrDefault(c => c.Id == id);

            if (client == null)
            {
                return HttpNotFound();
            }
            return View(client);
        }

        public ActionResult CompanyContactInfoDetails(int id = 1)
        {
            var info = context.CompanyContactInfos.FirstOrDefault(x => x.Id == id);

            if (info == null)
            {
                return HttpNotFound();
            }

            return View(info);
        }

        public ActionResult ClientContactInfoDetails(int id = 1)
        {
            var info = context.ClientContactInfos.FirstOrDefault(x => x.Id == id);

            if (info == null)
            {
                return HttpNotFound();
            }

            return View(info);
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

        public ViewResult Delete(int id)
        {
            var client = context.Clients.FirstOrDefault(x => x.Id == id);
            
            if (client != null)
            {
                context.Clients.Remove(client);
                context.SaveChanges();
                return View("List",context.Clients);
            }

            ModelState.AddModelError(String.Empty, "Spróbuj ponownie");
            return View("List");
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
                preclient.CompanyContactInfoId = client.CompanyContactInfoId;
                //preclient.EMail = client.EMail;
                //preclient.NIP = client.NIP;
                preclient.Name = client.Name;
                preclient.Surname = client.Surname;
                preclient.CompanyContactInfoId = client.CompanyContactInfoId;
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

        public ViewResult FakerCreate()
        {
            var amount = new FakerAmountViewModel();

            return View(amount);
        }

        [HttpPost]
        public ActionResult FakerCreate(FakerAmountViewModel faker)
        {
            var clientRepo = new ClientRepository();

            clientRepo.ClientFakerInsert(faker.Amount);

            return RedirectToAction("List");
        }
    }
}

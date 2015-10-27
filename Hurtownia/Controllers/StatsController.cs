using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Hurtownia.Models;
using Hurtownia.Models.ViewModels;

namespace Hurtownia.Controllers
{
    public class StatsController : Controller
    {
        private WholeSaleDbContext context;

        public ActionResult Index()
        {
            List<StatsViewModel> stats = new List<StatsViewModel>();
            context = new WholeSaleDbContext();

            foreach (var employee in context.Employees)
            {
                if (context.Orders.FirstOrDefault(x => x.EmployeeId == employee.Id) != null)
                {
                    stats.Add(new StatsViewModel()
                    {
                        Employee = employee,
                        Orders = context.Orders.Where(x => x.EmployeeId == employee.Id).ToList(),
                        OrderHelperList = new List<int>()
                    });
                }
            }

            foreach (var stat in stats)
            {
                stat.Orders.ForEach(x => stat.OrderHelperList.Add(x.Id));
            }

            return View(stats);
        }

    }
}

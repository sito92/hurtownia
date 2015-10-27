using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hurtownia.Models.ViewModels
{
    public class ClientViewModel
    {
        public IEnumerable<Client> Clients { get; set; }
    }
}
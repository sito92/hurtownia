using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Hurtownia.Models;

namespace Hurtownia.Interfaces
{
    public interface IProductTypeRepository
    {
        //Pobranie typu produktu po nazwie. I co ci tu kurwa wyskoczy, id? -.-'
        ProductType GetProductTypeByName(string name);

    }
}

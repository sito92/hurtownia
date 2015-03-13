using Hurtownia.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Hurtownia.Interfaces
{
    public interface IUnitRepository
    {
        //Pobranie jednostki po nazwie
        Unit GetUnitByName(string name);
    }
}

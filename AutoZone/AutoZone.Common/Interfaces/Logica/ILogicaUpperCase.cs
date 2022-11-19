using AutoZone.Common.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoZone.Common.Interfaces.Logica
{
    public interface ILogicaUpperCase
    {
        Task<List<Sucursal>> UpperCase(List<Sucursal> entrada);
    }
}

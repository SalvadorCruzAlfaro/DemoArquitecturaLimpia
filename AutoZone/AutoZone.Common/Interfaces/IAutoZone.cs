using AutoZone.Common.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoZone.Common.Interfaces
{
    public interface IAutoZone
    {
        Task<List<Sucursal>> ObtenerSucursalesAsync();
        Task<List<Sucursal>> ObtenerSucursalesPorNombreAsync(string nombre);
    }
}
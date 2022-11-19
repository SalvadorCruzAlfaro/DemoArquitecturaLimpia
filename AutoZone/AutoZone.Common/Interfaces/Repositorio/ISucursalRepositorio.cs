using AutoZone.Common.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoZone.Common.Interfaces.Repositorio
{
    public interface ISucursalRepositorio
    {
        Task<List<Sucursal>> ListarSucursalesAsync();
        Task<List<Sucursal>> ListarSucursalesPorNombreAsync(string nombre);
    }
}

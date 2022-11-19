using AutoZone.Common.Interfaces;
using AutoZone.Common.Interfaces.Repositorio;
using AutoZone.Common.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoZone.Infraestructura.Servicios
{
    public class AutoZoneService : IAutoZone
    {
        private readonly ISucursalRepositorio repositorio;
        public AutoZoneService(ISucursalRepositorio repositorio)
        {
            this.repositorio = repositorio;
        }

        public async Task<List<Sucursal>> ObtenerSucursalesAsync()
        {
            return await repositorio.ListarSucursalesAsync();
        }

        public async Task<List<Sucursal>> ObtenerSucursalesPorNombreAsync(string nombre)
        {
            return await repositorio.ListarSucursalesPorNombreAsync(nombre);
        }
    }
}

using AutoZone.Common.Interfaces.Repositorio;
using AutoZone.Common.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoZone.Infraestructura.AccesoDatos.Repositorios
{

    public class SucursalFakeRepositorio : ISucursalRepositorio
    {
        private readonly List<Sucursal> lista;
        public SucursalFakeRepositorio()
        {
            lista = new List<Sucursal>
            {
                new Sucursal
                {
                    Ciudad="Tehuanca",
                    Direccion="La de martin",
                    Estado="Puebla",
                    Nombre="Zona Alta",
                    Zona="Norte"
                },
                new Sucursal
                {
                    Ciudad="CDMX",
                    Direccion="Polanco",
                    Estado="CDMA",
                    Nombre="Polanco 1",
                    Zona="Poniente"
                },
            new Sucursal
                {
                    Ciudad="Tehuanca",
                    Direccion="Fovisste",
                    Estado="Puebla",
                    Nombre="Fovisste",
                    Zona="Sur"
                },
            new Sucursal
                {
                    Ciudad="Queretaro",
                    Direccion="Una calle",
                    Estado="Queretaro",
                    Nombre="Plaza 2",
                    Zona="Poniente"
                }
            };
        }
        public async Task<List<Sucursal>> ListarSucursalesAsync()
        {

            return lista;
        }

        public async Task<List<Sucursal>> ListarSucursalesPorNombreAsync(string nombre)
        {
            return lista.Where(x => x.Nombre.Equals(nombre)).ToList();
        }
    }
}

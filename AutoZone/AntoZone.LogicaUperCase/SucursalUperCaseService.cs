using AutoZone.Common.Interfaces.Logica;
using AutoZone.Common.Modelos;

namespace AntoZone.LogicaUperCase
{
    public class SucursalUperCaseService : ILogicaUpperCase
    {
        public async Task<List<Sucursal>> UpperCase(List<Sucursal> entrada)
        {
            return entrada.Select(s => new Sucursal
            {
                Ciudad = s.Ciudad.ToUpper(),
                Direccion = s.Direccion.ToUpper(),
                Estado = s.Estado.ToUpper(),
                Nombre = s.Nombre.ToUpper(),
                Zona = s.Zona.ToUpper()
            }).ToList();
        }
    }
}
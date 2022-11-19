using AutoZone.Common.Interfaces;
using AutoZone.Common.Interfaces.Logica;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoZone.Negocio.AutoZone.GetSucursales
{
    public class GetSucursalesHandler : IRequestHandler<GetSucursalesRequestModel, GetSucursalesResponseModel>
    {
        private readonly IAutoZone service;
        private readonly ILogicaUpperCase logica;

        public GetSucursalesHandler(IAutoZone service, ILogicaUpperCase logica)
        {
            this.service = service;
            this.logica = logica;
        }

        public async Task<GetSucursalesResponseModel> Handle(GetSucursalesRequestModel request, CancellationToken cancellationToken)
        {
            var resultado = await service.ObtenerSucursalesAsync();
            var listaUper = await logica.UpperCase(resultado);
            GetSucursalesResponseModel response = new GetSucursalesResponseModel { Response = listaUper };
            return response;
        }
    }
}

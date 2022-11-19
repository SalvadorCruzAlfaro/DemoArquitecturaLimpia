using AutoZone.Negocio.AutoZone.GetSucursales;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoZone.API.Controllers
{
    public class AutoZoneController : ApiControllerBase
    {
        [HttpGet(nameof(GetSucursales))]
        public async Task<ActionResult<GetSucursalesResponseModel>> GetSucursales(CancellationToken cancellationToken)
        {
            GetSucursalesRequestModel request=new GetSucursalesRequestModel();
            var resultado = await Mediator.Send(request, cancellationToken);
            return resultado;
        }
    }
}

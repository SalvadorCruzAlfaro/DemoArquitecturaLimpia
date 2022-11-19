using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoZone.Negocio
{
    public class EmptyHandler : IRequestHandler<EmptyRequestModel, EmptyResponseModel>
    {
        public Task<EmptyResponseModel> Handle(EmptyRequestModel request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }

    public class EmptyResponseModel { }
    public class EmptyRequestModel : IRequest<EmptyResponseModel> { }
}

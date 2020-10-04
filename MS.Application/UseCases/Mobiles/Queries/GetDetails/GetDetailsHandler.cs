using MediatR;
using MS.Domain.Abstractions.Repositories;
using MS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MS.Application.UseCases.Mobiles.Queries.GetDetails
{
    class GetDetailsHandler : IRequestHandler<GetDetailsRequest, Mobile>
    {
        private IMobilesRepository _mobilesRepository;
        public GetDetailsHandler(IMobilesRepository mobilesRepository)
        {
            _mobilesRepository = mobilesRepository;
        }

        public async Task<Mobile> Handle(GetDetailsRequest request, CancellationToken cancellationToken)
        {
            return await _mobilesRepository.GetDetails(request.ID);
        }
    }
}

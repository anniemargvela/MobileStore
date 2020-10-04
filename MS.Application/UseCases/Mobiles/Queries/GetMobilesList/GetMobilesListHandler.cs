using MediatR;
using MS.Domain.Abstractions.Repositories;
using MS.Domain.CommonModels;
using MS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MS.Application.UseCases.Mobiles.Queries.GetMobilesList
{
    public class GetMobilesListHandler : IRequestHandler<GetMobilesListRequest, Page<Mobile>>
    {
        private IMobilesRepository _mobilesRepository;
        public GetMobilesListHandler(IMobilesRepository mobilesRepository)
        {
            _mobilesRepository = mobilesRepository;
        }

        public async Task<Page<Mobile>> Handle(GetMobilesListRequest request, CancellationToken cancellationToken)
        {
            var filter = new MobilesFilter() {
                Manufacturer = request.Manufacturer,
                Name = request.Name,
                PriceFrom = request.PriceFrom,
                PriceTo = request.PriceTo,
                Page = request.Page
            };
            return await _mobilesRepository.GetMobilesList(filter);
        }
    }
}

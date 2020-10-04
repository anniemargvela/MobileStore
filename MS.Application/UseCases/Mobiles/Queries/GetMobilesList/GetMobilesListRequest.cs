using MediatR;
using MS.Domain.CommonModels;
using MS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MS.Application.UseCases.Mobiles.Queries.GetMobilesList
{
    public class GetMobilesListRequest : IRequest<Page<Mobile>>
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public int? PriceFrom { get; set; }
        public int? PriceTo { get; set; }
        public int Page { get; set; }
    }
}

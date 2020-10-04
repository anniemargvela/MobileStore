using MediatR;
using MS.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MS.Application.UseCases.Mobiles.Queries.GetDetails
{
    public class GetDetailsRequest : IRequest<Mobile>
    {
        public int ID { get; set; }
    }
}

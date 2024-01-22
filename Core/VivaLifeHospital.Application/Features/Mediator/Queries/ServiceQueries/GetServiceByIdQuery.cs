using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Application.Features.Mediator.Results.ServiceResult;

namespace VivaLifeHospital.Application.Features.Mediator.Queries.ServiceQueries
{
    public class GetServiceByIdQuery:IRequest<GetServiceByIdResult>
    {
        public int Id { get; set; }

        public GetServiceByIdQuery(int id)
        {
            Id = id;
        }
    }
}

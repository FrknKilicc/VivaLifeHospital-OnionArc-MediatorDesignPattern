using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Application.Features.Mediator.Results.ContactResult;

namespace VivaLifeHospital.Application.Features.Mediator.Queries.ContactQueries
{
    public class GetVisitorContactByIdQuery:IRequest<GetVisitorContactByIdResult>
    {
        public int Id { get; set; }

        public GetVisitorContactByIdQuery(int id)
        {
            Id = id;
        }
    }
}

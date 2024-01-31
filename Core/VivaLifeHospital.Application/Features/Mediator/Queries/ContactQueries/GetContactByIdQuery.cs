using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Application.Features.Mediator.Results.ContactResult;

namespace VivaLifeHospital.Application.Features.Mediator.Queries.ContactQueries
{
    public class GetContactByIdQuery:IRequest<GetContactByIdResult>
    {
        public int Id { get; set; }

        public GetContactByIdQuery(int id)
        {
            Id = id;
        }
    }
}

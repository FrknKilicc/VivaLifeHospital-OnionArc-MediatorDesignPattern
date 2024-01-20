using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Application.Features.Mediator.Results.DoctorResult;

namespace VivaLifeHospital.Application.Features.Mediator.Queries.DoctorQueries
{
    public class GetDoctorByIdQuery:IRequest<GetDoctorByIdResult>
    {
        public int Id { get; set; }

        public GetDoctorByIdQuery(int id)
        {
            Id = id;
        }
    }
}

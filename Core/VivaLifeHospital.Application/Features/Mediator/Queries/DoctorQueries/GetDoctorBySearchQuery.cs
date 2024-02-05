using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Application.Features.Mediator.Results.DoctorResult;

namespace VivaLifeHospital.Application.Features.Mediator.Queries.DoctorQueries
{
    public class GetDoctorBySearchQuery:IRequest<List<GetDoctorBySearchResult>>
    {
        public GetDoctorBySearchQuery(int id, string search)
        {
            Id = id;
            Search = search;
        }

        public int Id { get; set; }
        public string Search { get; set; }


    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Application.Features.Mediator.Results.DepartmentResult;

namespace VivaLifeHospital.Application.Features.Mediator.Queries.DepartmentQueries
{
    public class GetDepartmentWithDoctorQuery:IRequest<List<GetDepartmentWithDoctorResult>>
    {
        public int Id { get; set; }

        public GetDepartmentWithDoctorQuery(int id)
        {
            Id = id;
        }
    }
}

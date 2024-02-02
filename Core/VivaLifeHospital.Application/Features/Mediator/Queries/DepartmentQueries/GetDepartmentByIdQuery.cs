using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Application.Features.Mediator.Results.DepartmentResult;

namespace VivaLifeHospital.Application.Features.Mediator.Queries.DepartmentQueries
{
    public class GetDepartmentByIdQuery:IRequest<GetDepartmentByIdResult>
    {
        public int Id { get; set; }

        public GetDepartmentByIdQuery(int id)
        {
            Id = id;
        }
    }
}

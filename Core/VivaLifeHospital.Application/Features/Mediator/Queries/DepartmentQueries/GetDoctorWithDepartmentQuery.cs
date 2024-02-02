using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Application.Features.Mediator.Results.DepartmentResult;

namespace VivaLifeHospital.Application.Features.Mediator.Queries.DepartmentQueries
{
    public class GetDoctorWithDepartmentQuery:IRequest<List<GetDoctorWithDepartmentResult>>
    {
        public int DepartmenttId { get; set; }
    }
}

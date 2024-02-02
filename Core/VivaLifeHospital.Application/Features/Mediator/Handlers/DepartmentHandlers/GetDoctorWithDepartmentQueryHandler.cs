using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Application.Features.Mediator.Queries.DepartmentQueries;
using VivaLifeHospital.Application.Features.Mediator.Results.DepartmentResult;
using VivaLifeHospital.Application.Interfaces.DepartmentInterfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.DepartmentHandlers
{
    public class GetDoctorWithDepartmentQueryHandler : IRequestHandler<GetDoctorWithDepartmentQuery, List<GetDoctorWithDepartmentResult>>
    {
        private readonly IDepartmentRepository _departmentRepository;

        public GetDoctorWithDepartmentQueryHandler(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }

        public async Task<List<GetDoctorWithDepartmentResult>> Handle(GetDoctorWithDepartmentQuery request, CancellationToken cancellationToken)
        {
            var values = await _departmentRepository.GetDoctorByFilterAsync(x => x.DepartmentId == request.DepartmenttId);
            var results = values.Select(y=>new GetDoctorWithDepartmentResult
            {
                DoctorId=y.DoctorId
            }).ToList();
            return results;
        }
    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Application.Features.Mediator.Queries.DoctorQueries;
using VivaLifeHospital.Application.Features.Mediator.Results.DoctorResult;
using VivaLifeHospital.Application.Interfaces.DoctorInterfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.DoctorHandlers
{
    public class GetAllDoctorWithDepartmentQueryHandler : IRequestHandler<GetAllDoctorWithDepartmentQuery, List<GetAllDoctorWithDepartmentResult>>
    {
        private readonly IDoctorRepository _repository;

        public GetAllDoctorWithDepartmentQueryHandler(IDoctorRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAllDoctorWithDepartmentResult>> Handle(GetAllDoctorWithDepartmentQuery request, CancellationToken cancellationToken)
        {
            var values = _repository.GetAllDoctorWithDeparment();
            return values.Select(x=>new GetAllDoctorWithDepartmentResult
            {
                DoctorId = x.DoctorId,
                Name = x.Name,
                Description = x.Description,
                DoctorImgUrl = x.DoctorImgUrl,
                DepartmentId = x.DepartmentId,
                DepartmentName=x.Department.Name,
            }).ToList();
        }
    }
}

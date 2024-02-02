using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Features.Mediator.Queries.DepartmentQueries;
using VivaLifeHospital.Application.Features.Mediator.Results.DepartmentResult;
using VivaLifeHospital.Application.Interfaces.DepartmentInterfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.DepartmentHandlers
{
    public class GetDepartmentDoctorQueryHandler : IRequestHandler<GetDepartmentWithDoctorQuery, List<GetDepartmentWithDoctorResult>>
    {
        private readonly IDepartmentRepository _repository;

        public GetDepartmentDoctorQueryHandler(IDepartmentRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetDepartmentWithDoctorResult>> Handle(GetDepartmentWithDoctorQuery request, CancellationToken cancellationToken)
        {
            var value = _repository.GetDepartmentWithDoctor(request.Id);
            return value.Select(x=> new GetDepartmentWithDoctorResult
            {
                DepartmentId=x.DepartmentId,
                Name=x.Name,
                DoctorId=x.DoctorId,
            }).ToList();
        }
    }

}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Features.Mediator.Queries.DoctorQueries;
using VivaLifeHospital.Application.Features.Mediator.Results.DoctorResult;
using VivaLifeHospital.Application.Interfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.DoctorHandlers
{
    public class GetDoctorQueryHandler : IRequestHandler<GetDoctorQuery, List<GetDoctorResult>>
    {
        private readonly IRepository<Doctor> _repository;

        public GetDoctorQueryHandler(IRepository<Doctor> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetDoctorResult>> Handle(GetDoctorQuery request, CancellationToken cancellationToken)
        {
            var values =await _repository.GetAllAsync();
            return values.Select(x=>new GetDoctorResult
            {
                DoctorId = x.DoctorId,
                DepartmentId = x.DepartmentId,
                Name = x.Name,
                Description = x.Description,
                DoctorImgUrl = x.DoctorImgUrl
            }).ToList();
        }
    }
}

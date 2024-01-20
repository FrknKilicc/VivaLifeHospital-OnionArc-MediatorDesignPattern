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
    public class GetDoctorByIdQueryHandler : IRequestHandler<GetDoctorByIdQuery, GetDoctorByIdResult>
    {
        private readonly IRepository<Doctor> _repository;

        public GetDoctorByIdQueryHandler(IRepository<Doctor> repository)
        {
            _repository = repository;
        }

        public async Task<GetDoctorByIdResult> Handle(GetDoctorByIdQuery request, CancellationToken cancellationToken)
        {
           var values = await _repository.GetByIdAsync(request.Id);
            return new GetDoctorByIdResult
            {
                DepartmentId = values.DoctorId,
                Name = values.Name,
                DoctorImgUrl = values.DoctorImgUrl,
                Description = values.Description,
            };
        }
    }
}

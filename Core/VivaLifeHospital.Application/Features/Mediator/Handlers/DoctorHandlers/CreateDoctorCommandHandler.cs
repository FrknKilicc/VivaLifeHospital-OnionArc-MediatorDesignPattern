using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Features.Mediator.Commands.DoctorCommands;
using VivaLifeHospital.Application.Interfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.DoctorHandlers
{
    public class CreateDoctorCommandHandler : IRequestHandler<CreateDoctorCommand>
    {
        private readonly IRepository<Doctor> _repository;

        public CreateDoctorCommandHandler(IRepository<Doctor> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateDoctorCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Doctor
            {
                Name = request.Name,
                Description = request.Description,
                DepartmentId = request.DepartmentId,
                DoctorImgUrl = request.DoctorImgUrl,
            });
        }
    }
}

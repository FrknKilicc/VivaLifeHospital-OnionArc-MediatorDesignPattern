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
    public class UpdateDoctorCommandHandler : IRequestHandler<UpdateDoctorCommand>
    {
        private readonly IRepository<Doctor> _repository;

        public UpdateDoctorCommandHandler(IRepository<Doctor> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateDoctorCommand request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.DoctorId);
            values.Name = request.Name;
            values.Description = request.Description;
            values.DoctorImgUrl = request.DoctorImgUrl;
            values.DepartmentId = request.DepartmentId;
            await _repository.UpdateAsync(values);
        }
    }
}

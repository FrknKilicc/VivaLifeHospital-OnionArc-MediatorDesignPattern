using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Features.Mediator.Commands.AppointmentCommands;
using VivaLifeHospital.Application.Interfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.AppointmentHandlers
{
    public class CreateAppointmentCommandHandler:IRequestHandler<CreateAppointmentCommand>
    {
        private readonly IRepository<Appointment > _repository;

        public CreateAppointmentCommandHandler(IRepository<Appointment> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAppointmentCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Appointment
            {
                VisitorName = request.VisitorName,
                VisitorEMail = request.VisitorEMail,
                PhoneNumber = request.PhoneNumber,
                IsWoman = request.IsWoman,
                AppointmentDate = request.AppointmentDate,
                AppointmentTime = request.AppointmentTime,
                DoctorId = request.DoctorId,
                DepartmentId = request.DepartmentId,
            });
        }
    }
}

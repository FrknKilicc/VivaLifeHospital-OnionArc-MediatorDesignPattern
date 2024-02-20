using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Features.Mediator.Queries.AppointmentQueries;
using VivaLifeHospital.Application.Features.Mediator.Results.AppointmentResult;
using VivaLifeHospital.Application.Interfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.AppointmentHandlers
{
    public class GetAppointmentQueryHandler : IRequestHandler<GetAppointmentQuery, List<GetAppointmentResult>>
    {
        private readonly IRepository<Appointment> _repository;

        public GetAppointmentQueryHandler(IRepository<Appointment> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAppointmentResult>> Handle(GetAppointmentQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=> new GetAppointmentResult
            {
                VisitorId=x.VisitorId,
                VisitorName=x.VisitorName,
                VisitorEMail = x.VisitorEMail,
                PhoneNumber=x.PhoneNumber,
                IsWoman=x.IsWoman,
                AppointmentDate=x.AppointmentDate,
                AppointmentTime=x.AppointmentTime,
                DoctorId=x.DoctorId,
                DepartmentId=x.DepartmentId,
            }).ToList();

        }
    }
}

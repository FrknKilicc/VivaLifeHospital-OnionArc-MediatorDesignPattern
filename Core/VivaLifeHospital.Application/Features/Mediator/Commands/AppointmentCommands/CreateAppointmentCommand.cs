using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLifeHospital.Application.Features.Mediator.Commands.AppointmentCommands
{
    public class CreateAppointmentCommand:IRequest
    {
        public string VisitorName { get; set; }
        public string VisitorEMail { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsWoman { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string AppointmentTime { get; set; }
        public int? DoctorId { get; set; }
        public int? DepartmentId { get; set; }
    }
}

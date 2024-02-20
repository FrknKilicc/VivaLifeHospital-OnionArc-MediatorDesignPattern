using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;

namespace VivaLifeHospital.Application.Features.Mediator.Results.AppointmentResult
{
    public class GetAppointmentResult
    {
        public int VisitorId { get; set; }
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

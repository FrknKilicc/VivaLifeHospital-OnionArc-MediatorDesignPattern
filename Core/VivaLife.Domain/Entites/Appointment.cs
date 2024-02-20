using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLife.Domain.Entites
{
    public class Appointment
    {
        [Key]
        public int VisitorId { get; set; }
        [MaxLength(50)]
        public string VisitorName { get; set; }
        [EmailAddress]
        public string VisitorEMail { get; set; }
        [Phone()]
        public string PhoneNumber { get; set; }
        public bool IsWoman { get; set; }
        public DateTime AppointmentDate { get; set; }
        public string AppointmentTime { get; set; }
        public int? DoctorId { get; set; }
        public Doctor Doctor { get; set; }
        public int? DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}

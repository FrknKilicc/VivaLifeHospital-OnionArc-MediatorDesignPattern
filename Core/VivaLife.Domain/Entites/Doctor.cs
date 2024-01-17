using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLife.Domain.Entites
{
    public class Doctor
    {
        public int DoctorId { get; set; }
        public string DoctorImgUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLifeHospital.Dto.DoctorDtos
{
    public class ResultAllDoctorWithDepartmentDto
    {
        public int DoctorId { get; set; }
        public string DoctorImgUrl { get; set; }
        public string Name { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public int DepartmentId { get; set; }
    }
}

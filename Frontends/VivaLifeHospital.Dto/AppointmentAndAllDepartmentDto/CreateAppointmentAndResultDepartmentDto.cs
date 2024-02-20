using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Dto.AppointmentDto;
using VivaLifeHospital.Dto.DepartmentDtos;

namespace VivaLifeHospital.Dto.AppointmentAndAllDepartmentDto
{
    public class CreateAppointmentAndResultDepartmentDto
    {
        public CreateAppointmentDto AppointmentDto { get; set; }
        public List<ResultAllDepartmentDto> DepartmentDtos { get; set; }
    }
}

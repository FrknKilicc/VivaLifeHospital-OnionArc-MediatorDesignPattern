using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLifeHospital.Application.Features.Mediator.Results.DepartmentResult
{
    public class GetDepartmentWithDoctorResult
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public int DoctorId { get; set; }
    }
}

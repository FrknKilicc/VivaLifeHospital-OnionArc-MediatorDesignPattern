using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLifeHospital.Application.Features.Mediator.Commands.DoctorCommands
{
    public class UpdateDoctorCommand:IRequest
    {
        public int DoctorId { get; set; }
        public string DoctorImgUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DepartmentId { get; set; }
    }
}

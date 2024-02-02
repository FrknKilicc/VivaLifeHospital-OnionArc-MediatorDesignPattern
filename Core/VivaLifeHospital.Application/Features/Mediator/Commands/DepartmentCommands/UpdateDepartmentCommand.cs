using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLifeHospital.Application.Features.Mediator.Commands.DepartmentCommands
{
    public class UpdateDepartmentCommand:IRequest
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLifeHospital.Application.Features.Mediator.Commands.MedicalProgramCommands
{
    public class RemoveMedicalProgramCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveMedicalProgramCommand(int id)
        {
            Id = id;
        }
    }
}

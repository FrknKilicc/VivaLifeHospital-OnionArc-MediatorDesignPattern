using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLifeHospital.Application.Features.Mediator.Commands.ContactCommand
{
    public class RemoveVisitorContactCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveVisitorContactCommand(int id)
        {
            Id = id;
        }
    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLifeHospital.Application.Features.Mediator.Commands.ContactCommands
{
    public class CreateContactCommand:IRequest
    {
        public string ContactAddress { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string ContactMail { get; set; }
    }
}

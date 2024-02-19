using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLifeHospital.Application.Features.Mediator.Commands.TagsCloudCommands
{
    public class RemoveTagsCloudCommand:IRequest
    {
        public int Id { get; set; }

        public RemoveTagsCloudCommand(int id)
        {
            Id = id;
        }
    }
}

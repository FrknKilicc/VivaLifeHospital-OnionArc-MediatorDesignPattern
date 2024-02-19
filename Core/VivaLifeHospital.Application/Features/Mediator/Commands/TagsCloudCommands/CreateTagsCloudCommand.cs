using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLifeHospital.Application.Features.Mediator.Commands.TagsCloudCommands
{
    public class CreateTagsCloudCommand:IRequest
    {
        public string TagName { get; set; }
        public string BlogId { get; set; }
    }
}

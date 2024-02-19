using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLifeHospital.Application.Features.Mediator.Commands.TagsCloudCommands
{
    public class UpdateTagsCloudCommand:IRequest
    {
        public int TagCloudId { get; set; }
        public string TagName { get; set; }
        public int BlogId { get; set; }
    }
}

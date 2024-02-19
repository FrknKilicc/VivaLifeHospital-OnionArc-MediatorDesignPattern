using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLifeHospital.Application.Features.Mediator.Results.TagsCloudResult
{
    public class GetTagsCloudByIdResult
    {
        public int TagCloudId { get; set; }
        public string TagName { get; set; }
        public string BlogId { get; set; }
    }
}

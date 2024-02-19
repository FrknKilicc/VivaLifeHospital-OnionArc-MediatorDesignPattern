using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Application.Features.Mediator.Results.TagsCloudResult;

namespace VivaLifeHospital.Application.Features.Mediator.Queries.TagsCloudQueries
{
    public class GetTagsCloudQuery:IRequest<List<GetTagsCloudResult>>
    {
    }
}

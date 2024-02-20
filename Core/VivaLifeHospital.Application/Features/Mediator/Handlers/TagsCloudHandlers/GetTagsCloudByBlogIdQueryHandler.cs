using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Application.Features.Mediator.Queries.TagsCloudQueries;
using VivaLifeHospital.Application.Features.Mediator.Results.TagsCloudResult;
using VivaLifeHospital.Application.Interfaces.TagCloudInterfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.TagsCloudHandlers
{
    public class GetTagsCloudByBlogIdQueryHandler : IRequestHandler<GetTagsCloudByBlogIdQuery, List<GetTagsCloudByBlogIdResult>>
    {

        private readonly ITagCloudRepository _repository;

        public GetTagsCloudByBlogIdQueryHandler(ITagCloudRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTagsCloudByBlogIdResult>> Handle(GetTagsCloudByBlogIdQuery request, CancellationToken cancellationToken)
        {
            var value =  _repository.GetTagCloudByBlogId(request.Id);
            return value.Select(x => new GetTagsCloudByBlogIdResult
            {
                BlogId = x.BlogId,
                TagCloudId = x.TagCloudId,
                TagName = x.TagName,

            }).ToList();
            
        }
    }
}

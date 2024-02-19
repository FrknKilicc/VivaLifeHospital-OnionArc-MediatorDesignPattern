using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Features.Mediator.Queries.TagsCloudQueries;
using VivaLifeHospital.Application.Features.Mediator.Results.TagsCloudResult;
using VivaLifeHospital.Application.Interfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.TagsCloudHandlers
{
    public class GetTagsCloudQueryHandler : IRequestHandler<GetTagsCloudQuery, List<GetTagsCloudResult>>
    {
        private readonly IRepository<TagCloud> _repository;

        public GetTagsCloudQueryHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTagsCloudResult>> Handle(GetTagsCloudQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=> new GetTagsCloudResult
            {
                BlogId = x.BlogId,
                TagCloudId = x.TagCloudId,
                TagName=x.TagName,  
            }).ToList();
        }
    }
}

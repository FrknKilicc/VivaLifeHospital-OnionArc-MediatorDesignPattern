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
    public class GetTagsCloudByIdQueryHandler : IRequestHandler<GetTagsCloudByIdQuery, GetTagsCloudByIdResult>
    {
        private readonly IRepository<TagCloud> _repository;

        public GetTagsCloudByIdQueryHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task<GetTagsCloudByIdResult> Handle(GetTagsCloudByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetTagsCloudByIdResult
            {
                BlogId = value.BlogId,
                TagCloudId = value.TagCloudId,
                TagName = value.TagName,
            };
        }
    }
}

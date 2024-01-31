using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Features.Mediator.Queries.BlogQueries;
using VivaLifeHospital.Application.Features.Mediator.Results.BlogResult;
using VivaLifeHospital.Application.Interfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogByIdQueryHandler : IRequestHandler<GetBlogByIdQuery, GetBlogByIdResult>
    {
        private readonly IRepository<Blog> _repository;
    public async Task<GetBlogByIdResult> Handle(GetBlogByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetBlogByIdResult
            {
                AuthorId = value.AuthorId,
                BlogId = value.BlogId,
                BlogImgUrl = value.BlogImgUrl,
                CategoryId = value.CategoryId,
                CreatedDateTime = value.CreatedDateTime,
                Description = value.Description,
                Title = value.Title,
            };
        }
    }
}

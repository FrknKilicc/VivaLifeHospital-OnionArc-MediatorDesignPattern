using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Features.Mediator.Queries.BlogQueries;
using VivaLifeHospital.Application.Features.Mediator.Results.BlogResult;
using VivaLifeHospital.Application.Interfaces.BlogInterfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogWithAuthorNdCategoryQueryHandler : IRequestHandler<GetBlogWithAuthorNdCategoryQuery, List<GetBlogWithAuthorNdCategoryResult>>
    {
        private readonly IBlogRepository _repository;

        public GetBlogWithAuthorNdCategoryQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBlogWithAuthorNdCategoryResult>> Handle(GetBlogWithAuthorNdCategoryQuery request, CancellationToken cancellationToken)
        {
            var value =  _repository.GetBlogsWithAuthorNdCategory();
            return value.Select(x => new GetBlogWithAuthorNdCategoryResult
            {
                AuthorId = x.AuthorId,
                AuthorName = x.Author.Name,
                AuthorImg=x.Author.AuthorImgUrl,
                BlogId = x.BlogId,
                BlogImgUrl = x.BlogImgUrl,
                CategoryId = x.CategoryId,
                CategoryName = x.Category.Name,
                CreatedDateTime = x.CreatedDateTime,
                Description = x.Description,
                Title = x.Title
            }).ToList() ;
        }
    }
}

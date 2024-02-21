using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Application.Features.Mediator.Queries.BlogQueries;
using VivaLifeHospital.Application.Features.Mediator.Results.BlogResult;
using VivaLifeHospital.Application.Interfaces.BlogInterfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogBySearchQueryHandler : IRequestHandler<GetBlogBySearchQuery, List<GetBlogBySearchResult>>
    {
        private readonly IBlogRepository _blogRepository;

        public GetBlogBySearchQueryHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task<List<GetBlogBySearchResult>> Handle(GetBlogBySearchQuery request, CancellationToken cancellationToken)
        {
                var values = _blogRepository.GetBlogsBySearch(request.keyword);
                return values.Select(x => new GetBlogBySearchResult
                {
                    AuthorId = x.AuthorId,
                    AuthorImg=x.Author.AuthorImgUrl,
                    AuthorName=x.Author.Name,
                    BlogId=x.BlogId,
                    BlogImgUrl=x.BlogImgUrl,
                    CategoryId=x.CategoryId,
                    CategoryName=x.Category.Name,
                    CreatedDateTime=x.CreatedDateTime,
                    Description=x.Description,
                    Title=x.Title,
                }).ToList();
        }
    }
}

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
    public class GetBlogQueryHandler : IRequestHandler<GetBlogQuery, List<GetBlogResult>>
    {
        private readonly IRepository<Blog> _repository;

        public GetBlogQueryHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBlogResult>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetAllAsync();
            return  value.Select(x=> new GetBlogResult
            {
                AuthorId = x.AuthorId,
                BlogId = x.BlogId,
                BlogImgUrl = x.BlogImgUrl,
                CategoryId = x.CategoryId,
                CreatedDateTime = x.CreatedDateTime,
                Description = x.Description,
                Title=x.Title,
            }).ToList();
        }
    }
}

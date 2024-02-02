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
    public class GetLast3BlogQueryHandler : IRequestHandler<GetLast3BlogQuery, List<GetLast3BlogResult>>
    {
        private readonly IBlogRepository _repository;

        public GetLast3BlogQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetLast3BlogResult>> Handle(GetLast3BlogQuery request, CancellationToken cancellationToken)
        {
            var value =  _repository.GetLast3BlogsWithAuthorNdCategory();
            return value.Select(x=>new GetLast3BlogResult
            {
                AuthorId = x.AuthorId,
                AuthorImg =x.Author.AuthorImgUrl,
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

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Application.Features.Mediator.Queries.BlogQueries;
using VivaLifeHospital.Application.Features.Mediator.Results.BlogResult;
using VivaLifeHospital.Application.Interfaces.BlogInterfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogByIdWithAuthorIdQueryHandler : IRequestHandler<GetBlogByIdWithAuthorIdQuery, GetBlogByIdWithAuthorIdResult>
    {
        private readonly IBlogRepository _repository;

        public GetBlogByIdWithAuthorIdQueryHandler(IBlogRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetBlogByIdWithAuthorIdResult> Handle(GetBlogByIdWithAuthorIdQuery request, CancellationToken cancellationToken)
        {
            var values =  _repository.GetBlogByIdWithAuthor(request.Id);
            return new GetBlogByIdWithAuthorIdResult
            {
                BlogId = values.BlogId,
                Title = values.Title,
                 CreatedDateTime = values.CreatedDateTime,
                BlogDescription=values.Description,
                BlogImgUrl=values.BlogImgUrl,
                AuthorId=values.AuthorId,
                Name=values.Author.Name,
                Description=values.Author.Description,
                AuthorImgUrl = values.Author.AuthorImgUrl,

            };
        }
    }
}

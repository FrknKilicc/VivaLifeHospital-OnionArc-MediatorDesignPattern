using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Application.Features.Mediator.Queries.CommentQueries;
using VivaLifeHospital.Application.Features.Mediator.Results.CommentResult;
using VivaLifeHospital.Application.Interfaces.CommentInterfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.CommentHandlers
{
    public class GetCommentByBlogIdQueryHandler : IRequestHandler<GetCommentByBlogIdQuery, List<GetCommentByBlogIdResult>>
    {
        private readonly ICommentRepository _commentRepository;

        public GetCommentByBlogIdQueryHandler(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public async Task<List<GetCommentByBlogIdResult>> Handle(GetCommentByBlogIdQuery request, CancellationToken cancellationToken)
        {
            var values =  _commentRepository.GetCommentByBlogId(request.Id);
            return values.Select(x => new GetCommentByBlogIdResult
            {
                BlogId = x.BlogId,
                CommentId = x.CommentId,
                CreatedDate = x.CreatedDate,
                Description = x.Description,
                Name = x.Name,
            }).ToList();
        }
    }
}

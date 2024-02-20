using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Application.Features.Mediator.Results.CommentResult;

namespace VivaLifeHospital.Application.Features.Mediator.Queries.CommentQueries
{
    public class GetCommentByBlogIdQuery:IRequest<List<GetCommentByBlogIdResult>>
    {
        public int Id { get; set; }
        public GetCommentByBlogIdQuery(int id)
        {
            Id = id;
        }
    }
}

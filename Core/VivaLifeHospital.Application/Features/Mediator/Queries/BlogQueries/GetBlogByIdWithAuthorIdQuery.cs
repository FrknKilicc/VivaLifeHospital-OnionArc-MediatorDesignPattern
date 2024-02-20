using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Application.Features.Mediator.Results.BlogResult;

namespace VivaLifeHospital.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetBlogByIdWithAuthorIdQuery:IRequest<GetBlogByIdWithAuthorIdResult>
    {
        public int Id { get; set; }

        public GetBlogByIdWithAuthorIdQuery(int id)
        {
            Id = id;
        }
    }
}

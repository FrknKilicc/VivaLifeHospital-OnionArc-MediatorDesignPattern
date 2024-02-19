using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Application.Features.Mediator.Queries.BlogQueries;
using VivaLifeHospital.Application.Features.Mediator.Results.BlogResult;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class GetBlogByIdWithAuthorIdQueryHandler : IRequestHandler<GetBlogByIdWithAuthorIdQuery, List<GetBlogByIdWithAuthorIdResult>>
    {
        
        public Task<List<GetBlogByIdWithAuthorIdResult>> Handle(GetBlogByIdWithAuthorIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

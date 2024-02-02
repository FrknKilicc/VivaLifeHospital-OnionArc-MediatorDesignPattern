using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Application.Features.Mediator.Results.BlogResult;

namespace VivaLifeHospital.Application.Features.Mediator.Queries.BlogQueries
{
    public class GetBlogWithAuthorNdCategoryQuery:IRequest<List<GetBlogWithAuthorNdCategoryResult>>
    {
    }
}

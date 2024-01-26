using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Application.Features.Mediator.Results.AuthorResult;

namespace VivaLifeHospital.Application.Features.Mediator.Queries.AuthorQueries
{
    public class GetAuthorQuery:IRequest<List<GetAuthorResult>>
    {
    }
}

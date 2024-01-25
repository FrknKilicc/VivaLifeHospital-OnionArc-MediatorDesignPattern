using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Application.Features.Mediator.Results.CategoryResult;

namespace VivaLifeHospital.Application.Features.Mediator.Queries.CategoryQueries
{
    public class GetCategoryByIdQuery:IRequest<GetCategoryByIdResult>
    {
        public int Id { get; set; }

        public GetCategoryByIdQuery(int id)
        {
            Id = id;
        }
    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Features.Mediator.Queries.CategoryQueries;
using VivaLifeHospital.Application.Features.Mediator.Results.CategoryResult;
using VivaLifeHospital.Application.Interfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.CategoryHandlers
{
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQuery, List<GetCategoryResult>>
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCategoryResult>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetAllAsync();
            return value.Select(x => new GetCategoryResult
            {
                CategoryId = x.CategoryId,
                Name = x.Name,
            }).ToList();
        }
    }
}

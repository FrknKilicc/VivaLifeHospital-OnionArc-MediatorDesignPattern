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
    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQuery, GetCategoryByIdResult>
    {
        private readonly IRepository<Category> _repository;

        public GetCategoryByIdQueryHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task<GetCategoryByIdResult> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
           var value = await _repository.GetByIdAsync(request.Id);
            return new GetCategoryByIdResult
            {
                CategoryId = value.CategoryId,
                Name = value.Name,
            };
        }
    }
}

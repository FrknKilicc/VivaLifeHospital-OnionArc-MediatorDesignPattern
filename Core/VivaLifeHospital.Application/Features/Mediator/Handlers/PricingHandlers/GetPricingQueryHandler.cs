using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Features.Mediator.Queries.PricingQueries;
using VivaLifeHospital.Application.Features.Mediator.Results.PricingResult;
using VivaLifeHospital.Application.Interfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.PricingHandlers
{
    public class GetPricingQueryHandler : IRequestHandler<GetPricingQuery, List<GetPricingResult>>
    {
        private readonly IRepository<Pricing> _repository;

        public GetPricingQueryHandler(IRepository<Pricing> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetPricingResult>> Handle(GetPricingQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetAllAsync();
        return value.Select(x=> new GetPricingResult{

            Amount=x.Amount,
            Name=x.Name,
            PricingId=x.PricingId,
        }).ToList();
        }
    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Features.Mediator.Queries.BannerQueries;
using VivaLifeHospital.Application.Features.Mediator.Results.BannerResult;
using VivaLifeHospital.Application.Interfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.BannerHandlers
{
    public class GetBannerQueryHandler : IRequestHandler<GetBannerQuery, List<GetBannerResult>>
    {
        private readonly IRepository<Banner> _repository;

        public GetBannerQueryHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetBannerResult>> Handle(GetBannerQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x=> new GetBannerResult
            {
                BannerId = x.BannerId,
                BannerImageUrl = x.BannerImageUrl,
                Description = x.Description,
                Title=x.Title,
            }).ToList();
        }
    }
}

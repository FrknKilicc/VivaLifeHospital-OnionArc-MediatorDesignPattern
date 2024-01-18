using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Features.Mediator.Queries.AboutQueries;
using VivaLifeHospital.Application.Features.Mediator.Results.AboutResult;
using VivaLifeHospital.Application.Interfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.AboutHandlers
{
    public class GetAboutQueryResult : IRequestHandler<GetAboutQuery, List<GetAboutResult>>
    {
        private readonly IRepository<About> _repository;

        public GetAboutQueryResult(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAboutResult>> Handle(GetAboutQuery request, CancellationToken cancellationToken)
        {
           var values = await _repository.GetAllAsync();
            return values.Select(x=> new GetAboutResult
            {
                AboutId=x.AboutId,
                AboutImageUrl=x.AboutImageUrl,
                Title=x.Title,
                Description=x.Description,
            }).ToList();
        }
    }
}

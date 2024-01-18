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
    public class GetAboutByIdQueryResult : IRequestHandler<GetAboutByIdQuery, GetAboutByIdResult>
    {
        private readonly IRepository<About> _repository;

        public GetAboutByIdQueryResult(IRepository<About> repository)
        {
            _repository = repository;
        }

        public async Task<GetAboutByIdResult> Handle(GetAboutByIdQuery request, CancellationToken cancellationToken)
        {
            var values = await _repository.GetByIdAsync(request.Id);
            return new GetAboutByIdResult
            {
                AboutId = values.AboutId,
                AboutImageUrl = values.AboutImageUrl,
                Description = values.Description,
                Title = values.Title,
            };
        }
       
    }
}

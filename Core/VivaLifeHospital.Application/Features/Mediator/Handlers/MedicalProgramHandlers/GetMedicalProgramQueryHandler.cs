using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Features.Mediator.Queries.MedicalProgramQueries;
using VivaLifeHospital.Application.Features.Mediator.Results.MedicalProgramResult;
using VivaLifeHospital.Application.Interfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.MedicalProgramHandlers
{
    public class GetMedicalProgramQueryHandler : IRequestHandler<GetMedicalProgramQuery, List<GetMedicalProgramResult>>
    {
        private readonly IRepository<MedicalProgram> _repository;

        public GetMedicalProgramQueryHandler(IRepository<MedicalProgram> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetMedicalProgramResult>> Handle(GetMedicalProgramQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetAllAsync();

            return value.Select(x => new GetMedicalProgramResult
            {
                Description = x.Description,
                MedicalProgramCoverImgUrl = x.MedicalProgramCoverImgUrl,
                MedicalProgramId = x.MedicalProgramId,
                Title = x.Title,
                PricingId = x.PricingId,
            }).ToList();
        }
    }
}

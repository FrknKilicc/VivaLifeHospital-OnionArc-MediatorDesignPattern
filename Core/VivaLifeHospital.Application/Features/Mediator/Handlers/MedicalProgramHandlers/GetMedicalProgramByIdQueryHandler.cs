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
    public class GetMedicalProgramByIdQueryHandler : IRequestHandler<GetMedicalProgramByIdQuery, GetMedicalProgramByIdResult>
    {
        private readonly IRepository<MedicalProgram> _repository;

        public GetMedicalProgramByIdQueryHandler(IRepository<MedicalProgram> repository)
        {
            _repository = repository;
        }

        public async Task<GetMedicalProgramByIdResult> Handle(GetMedicalProgramByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetMedicalProgramByIdResult
            {
                Description = value.Description,
                MedicalProgramCoverImgUrl = value.MedicalProgramCoverImgUrl,
                MedicalProgramId = value.MedicalProgramId,
                PricingId = value.PricingId,
                Title = value.Title,
            };
        }
    }
}

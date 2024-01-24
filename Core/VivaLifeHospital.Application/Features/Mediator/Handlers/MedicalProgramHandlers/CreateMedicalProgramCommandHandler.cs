using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Features.Mediator.Commands.MedicalProgramCommands;
using VivaLifeHospital.Application.Interfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.MedicalProgramHandlers
{
    public class CreateMedicalProgramCommandHandler : IRequestHandler<CreateMedicalProgramCommand>
    {
        private readonly IRepository<MedicalProgram> _repository;

        public CreateMedicalProgramCommandHandler(IRepository<MedicalProgram> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateMedicalProgramCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new MedicalProgram
            {
                Description = request.Description,
                MedicalProgramCoverImgUrl = request.MedicalProgramCoverImgUrl,
                Title = request.Title,
                PricingId = request.PricingId,
            });
        }
    }
}

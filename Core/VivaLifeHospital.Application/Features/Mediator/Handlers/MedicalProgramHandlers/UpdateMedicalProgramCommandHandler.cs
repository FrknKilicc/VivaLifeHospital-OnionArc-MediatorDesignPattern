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
    public class UpdateMedicalProgramCommandHandler : IRequestHandler<UpdateMedicalProgramCommand>
    {
        private readonly IRepository<MedicalProgram> _repository;

        public UpdateMedicalProgramCommandHandler(IRepository<MedicalProgram> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateMedicalProgramCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.MedicalProgramId);
            value.Description = request.Description;
            value.Title = request.Title;
            value.MedicalProgramCoverImgUrl = request.MedicalProgramCoverImgUrl;
            value.PricingId = request.PricingId;
            await _repository.UpdateAsync(value);
            
        }
    }
}

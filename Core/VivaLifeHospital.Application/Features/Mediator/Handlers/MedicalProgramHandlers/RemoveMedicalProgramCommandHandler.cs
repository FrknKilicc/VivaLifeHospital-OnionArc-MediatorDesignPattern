﻿using MediatR;
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
    public class RemoveMedicalProgramCommandHandler : IRequestHandler<RemoveMedicalProgramCommand>
    {
        private readonly IRepository<MedicalProgram> _repository;

        public RemoveMedicalProgramCommandHandler(IRepository<MedicalProgram> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveMedicalProgramCommand request, CancellationToken cancellationToken)
        {
           var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}

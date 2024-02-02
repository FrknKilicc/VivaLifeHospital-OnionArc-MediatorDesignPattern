using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Features.Mediator.Commands.DepartmentCommands;
using VivaLifeHospital.Application.Interfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.DepartmentHandlers
{
    public class RemoveDepartmentCommandHandler : IRequestHandler<RemoveDepartmentCommand>
    {
        private readonly IRepository<Department> _repository;

        public RemoveDepartmentCommandHandler(IRepository<Department> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveDepartmentCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}

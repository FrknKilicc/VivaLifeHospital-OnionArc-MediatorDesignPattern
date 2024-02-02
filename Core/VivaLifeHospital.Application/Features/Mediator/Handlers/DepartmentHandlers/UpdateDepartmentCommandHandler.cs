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
    public class UpdateDepartmentCommandHandler : IRequestHandler<UpdateDepartmentCommand>
    {
        private readonly IRepository<Department> _repository;

        public UpdateDepartmentCommandHandler(IRepository<Department> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.DepartmentId);
            value.Name = request.Name;
            await _repository.UpdateAsync(value);
        }
    }
}

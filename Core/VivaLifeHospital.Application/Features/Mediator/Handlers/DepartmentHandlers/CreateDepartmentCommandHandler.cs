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
    public class CreateDepartmentCommandHandler : IRequestHandler<CreateDepartmentCommand>
    {
        private readonly IRepository<Department> _repository;

        public CreateDepartmentCommandHandler(IRepository<Department> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateDepartmentCommand request, CancellationToken cancellationToken)
        {
            var value =  _repository.CreateAsync(new Department
            {
                Name = request.Name,
            });
        }
    }
}

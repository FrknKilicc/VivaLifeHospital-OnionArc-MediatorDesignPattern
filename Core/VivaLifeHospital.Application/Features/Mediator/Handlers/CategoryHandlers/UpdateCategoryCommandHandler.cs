using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Features.Mediator.Commands.CategoryCommands;
using VivaLifeHospital.Application.Interfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.CategoryHandlers
{
    public class UpdateCategoryCommandHandler : IRequestHandler<UpdateCategoryCommand>
    {
        private readonly IRepository<Category> _repository;

        public UpdateCategoryCommandHandler(IRepository<Category> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateCategoryCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.CategoryId);
            value.Name = request.Name;
            await _repository.UpdateAsync(value);
        }
    }
}

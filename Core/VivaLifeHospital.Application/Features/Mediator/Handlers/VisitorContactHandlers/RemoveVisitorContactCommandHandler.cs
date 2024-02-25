using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Features.Mediator.Commands.ContactCommand;
using VivaLifeHospital.Application.Interfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.ContactHandlers
{
    public class RemoveVisitorContactCommandHandler : IRequestHandler<RemoveVisitorContactCommand>
    {
        private readonly IRepository<VisitorContact> _repository;

        public RemoveVisitorContactCommandHandler(IRepository<VisitorContact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveVisitorContactCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            await _repository.RemoveAsync(value);
        }
    }
}

using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Features.Mediator.Commands.BlogCommands;
using VivaLifeHospital.Application.Features.Mediator.Commands.ContactCommand;
using VivaLifeHospital.Application.Interfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.ContactHandlers
{
    public class CreateVisitorContactCommandHandler : IRequestHandler<CreateVisitorContactCommand>
    {
        private readonly IRepository<VisitorContact> _repository;

        public CreateVisitorContactCommandHandler(IRepository<VisitorContact> repository)
        {
            _repository = repository;
        }
        public async Task Handle(CreateVisitorContactCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new VisitorContact
            {
                Email = request.Email,
                Message = request.Message,
                Name = request.Name,
                SendDate = request.SendDate,
                Subject = request.Subject
            });
        }
    }
}

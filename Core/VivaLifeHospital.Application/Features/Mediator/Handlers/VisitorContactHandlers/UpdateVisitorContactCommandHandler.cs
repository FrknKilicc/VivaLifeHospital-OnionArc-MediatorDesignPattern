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
    public class UpdateVisitorContactCommandHandler : IRequestHandler<UpdateVisitorContactCommand>
    {
        private readonly IRepository<VisitorContact> _repository;

        public UpdateVisitorContactCommandHandler(IRepository<VisitorContact> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateVisitorContactCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.VisitorContactID);
            value.Email = request.Email;
            value.SendDate = request.SendDate;
            value.Subject = request.Subject;
            value.SendDate = request.SendDate;
            value.Message = request.Message;
            await _repository.UpdateAsync(value);
        }
    }
}

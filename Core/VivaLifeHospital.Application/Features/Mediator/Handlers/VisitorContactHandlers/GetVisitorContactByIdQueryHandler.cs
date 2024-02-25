using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Features.Mediator.Queries.ContactQueries;
using VivaLifeHospital.Application.Features.Mediator.Results.ContactResult;
using VivaLifeHospital.Application.Interfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.ContactHandlers
{
    public class GetVisitorContactByIdQueryHandler : IRequestHandler<GetVisitorContactByIdQuery, GetVisitorContactByIdResult>
    {
        private readonly IRepository<VisitorContact> _repository;

        public GetVisitorContactByIdQueryHandler(IRepository<VisitorContact> repository)
        {
            _repository = repository;
        }

        public async Task<GetVisitorContactByIdResult> Handle(GetVisitorContactByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetVisitorContactByIdResult
            {
                VisitorContactID = value.VisitorContactID,
                Email = value.Email,
                Message = value.Message,
                Name = value.Name,
                SendDate = value.SendDate,
                Subject = value.Subject,
            };
        }
    }
}

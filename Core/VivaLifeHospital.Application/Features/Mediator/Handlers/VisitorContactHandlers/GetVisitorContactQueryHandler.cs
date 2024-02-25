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
    public class GetVisitorContactQueryHandler : IRequestHandler<GetVisitorContactQuery, List<GetVisitorContactResult>>
    {
        private readonly IRepository<VisitorContact> _repository;

        public GetVisitorContactQueryHandler(IRepository<VisitorContact> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetVisitorContactResult>> Handle(GetVisitorContactQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetAllAsync();
            return value.Select(x => new GetVisitorContactResult
            {
                VisitorContactID = x.VisitorContactID,
                Email = x.Email,
                Message = x.Message,
                Name = x.Name,
                SendDate = x.SendDate,
                Subject = x.Subject
            }).ToList();
        }
    }
}

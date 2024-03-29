﻿using MediatR;
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
    public class GetContactQueryHandler : IRequestHandler<GetContactQuery, List<GetContactResult>>
    {
        private readonly IRepository<Contact> _repository;

        public GetContactQueryHandler(IRepository<Contact> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetContactResult>> Handle(GetContactQuery request, CancellationToken cancellationToken)
        {
           var value = await _repository.GetAllAsync();
           return value.Select(z=>new GetContactResult
           {
               ContactId = z.ContactId,
               ContactAddress = z.ContactAddress,
               ContactMail = z.ContactMail,
               ContactPhoneNumber = z.ContactPhoneNumber,
           }).ToList();
        }
    }
}

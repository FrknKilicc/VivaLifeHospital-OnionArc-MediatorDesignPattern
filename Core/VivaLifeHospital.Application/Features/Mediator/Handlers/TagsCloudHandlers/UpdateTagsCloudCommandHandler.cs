﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Features.Mediator.Commands.TagsCloudCommands;
using VivaLifeHospital.Application.Interfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.TagsCloudHandlers
{
    public class UpdateTagsCloudCommandHandler : IRequestHandler<UpdateTagsCloudCommand>
    {
        private readonly IRepository<TagCloud> _repository;

        public UpdateTagsCloudCommandHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateTagsCloudCommand request, CancellationToken cancellationToken)
        {
           var values= await _repository.GetByIdAsync(request.TagCloudId);
            values.TagName = request.TagName;
            values.BlogId = request.BlogId;
            await _repository.UpdateAsync(values);
        }
    }
}

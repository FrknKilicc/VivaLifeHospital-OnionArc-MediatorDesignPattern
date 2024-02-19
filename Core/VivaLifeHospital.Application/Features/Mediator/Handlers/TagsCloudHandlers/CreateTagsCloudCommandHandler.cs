using MediatR;
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
    public class CreateTagsCloudCommandHandler:IRequestHandler<CreateTagsCloudCommand>
    {
        private readonly IRepository<TagCloud> _repository;

        public CreateTagsCloudCommandHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateTagsCloudCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new TagCloud
            {

                BlogId = request.BlogId,
                TagName = request.TagName,
            });
        }
    }
}

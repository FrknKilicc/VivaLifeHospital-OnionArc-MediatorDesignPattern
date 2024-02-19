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
    public class RemoveTagsCloudCommandHandler : IRequestHandler<RemoveTagsCloudCommand>
    {
        private readonly IRepository<TagCloud> _repository;

        public RemoveTagsCloudCommandHandler(IRepository<TagCloud> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveTagsCloudCommand request, CancellationToken cancellationToken)
        {
         var values = await _repository.GetByIdAsync(request.Id);
          await _repository.RemoveAsync(values);
        }
    }
}

using MediatR;
using MediatR.Pipeline;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Features.Mediator.Commands.BannerCommands;
using VivaLifeHospital.Application.Interfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.BannerHandlers
{
    public class CreateBannerCommandHandler : IRequestHandler<CreateBannerCommand>
    {
        private readonly IRepository<Banner> _repository;

        public CreateBannerCommandHandler(IRepository<Banner> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateBannerCommand request, CancellationToken cancellationToken)
        {
            await _repository.CreateAsync(new Banner
            {
                BannerImageUrl = request.BannerImageUrl,
                Description = request.Description,
                Title = request.Title,
            });
        }
    }
}

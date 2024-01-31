using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Features.Mediator.Commands.BlogCommands;
using VivaLifeHospital.Application.Interfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.BlogHandlers
{
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand>
    {
        private readonly IRepository<Blog> _repository;

        public UpdateBlogCommandHandler(IRepository<Blog> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.BlogId);
            value.Title = request.Title;
            value.Description = request.Description;
            value.AuthorId = request.AuthorId;
            value.BlogImgUrl = request.BlogImgUrl;
            value.CategoryId = request.CategoryId;
            value.CreatedDateTime = request.CreatedDateTime;
            await _repository.UpdateAsync(value);

        }
    }
}

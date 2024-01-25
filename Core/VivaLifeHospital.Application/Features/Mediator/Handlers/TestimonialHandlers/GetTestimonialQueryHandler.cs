using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Features.Mediator.Queries.TestimonialQueries;
using VivaLifeHospital.Application.Features.Mediator.Results.TestimonialResult;
using VivaLifeHospital.Application.Interfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.TestimonialHandlers
{
    public class GetTestimonialQueryHandler : IRequestHandler<GetTestimonialQuery, List<GetTestimonialResult>>
    {
        private readonly IRepository<Testimonial> _repository;

        public GetTestimonialQueryHandler(IRepository<Testimonial> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetTestimonialResult>> Handle(GetTestimonialQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetAllAsync();
            return value.Select(x=> new GetTestimonialResult
            {
                Comment=x.Comment,
                ImageUrl=x.ImageUrl,
                Name=x.Name,
                TestimonialID=x.TestimonialID,
                Title=x.Title,
            }).ToList();
        }
    }
}

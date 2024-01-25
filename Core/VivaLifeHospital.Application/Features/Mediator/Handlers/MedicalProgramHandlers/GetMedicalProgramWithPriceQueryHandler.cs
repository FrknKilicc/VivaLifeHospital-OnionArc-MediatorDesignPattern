using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Application.Features.Mediator.Queries.MedicalProgramQueries;
using VivaLifeHospital.Application.Features.Mediator.Results.MedicalProgramResult;
using VivaLifeHospital.Application.Interfaces.MedicalProgramInterfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.MedicalProgramHandlers
{
    public class GetMedicalProgramWithPriceQueryHandler : IRequestHandler<GetMedicalProgramWithPriceQuery, List<GetMedicalProgramWithPriceResult>>
    {
        private readonly IMedicalProgramRepository _medicalProgramRepository;

        public GetMedicalProgramWithPriceQueryHandler(IMedicalProgramRepository medicalProgramRepository)
        {
            _medicalProgramRepository = medicalProgramRepository;
        }

        public async Task<List<GetMedicalProgramWithPriceResult>> Handle(GetMedicalProgramWithPriceQuery request, CancellationToken cancellationToken)
        {
            var value = _medicalProgramRepository.MedicalProgramWithPrice();
            return value.Select(x => new GetMedicalProgramWithPriceResult
            {
                Title = x.Title,
                Description = x.Description,
                MedicalProgramCoverImgUrl = x.MedicalProgramCoverImgUrl,
                MedicalProgramId=x.MedicalProgramId,
                Amount = x.Pricing.Amount,
                PricingId = x.PricingId,
                Name = x.Pricing.Name,
            }).ToList();

        }
    }
}

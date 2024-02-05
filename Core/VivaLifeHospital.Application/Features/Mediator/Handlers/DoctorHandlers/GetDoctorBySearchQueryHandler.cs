using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Application.Features.Mediator.Queries.DoctorQueries;
using VivaLifeHospital.Application.Features.Mediator.Results.DoctorResult;
using VivaLifeHospital.Application.Interfaces.DoctorInterfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.DoctorHandlers
{
    public class GetDoctorBySearchQueryHandler : IRequestHandler<GetDoctorBySearchQuery, List<GetDoctorBySearchResult>>
    {
        private readonly IDoctorRepository _repository;

        public GetDoctorBySearchQueryHandler(IDoctorRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<GetDoctorBySearchResult>> Handle(GetDoctorBySearchQuery request, CancellationToken cancellationToken)
        {
            var values =  _repository.GetDoctorWithDepartmentBySearch(request.Id, request.Search);
            return values.Select(x => new GetDoctorBySearchResult
            {
                DepartmentId=x.DepartmentId,
                DepartmentName=x.Department.Name,
                DoctorId=x.DoctorId,
                Name=x.Name,
                Description=x.Description,
                DoctorImgUrl=x.DoctorImgUrl,
            }).ToList();
        }
    }
}

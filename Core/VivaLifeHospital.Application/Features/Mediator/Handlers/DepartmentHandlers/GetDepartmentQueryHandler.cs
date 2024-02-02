using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Features.Mediator.Queries.DepartmentQueries;
using VivaLifeHospital.Application.Features.Mediator.Results.DepartmentResult;
using VivaLifeHospital.Application.Interfaces;

namespace VivaLifeHospital.Application.Features.Mediator.Handlers.DepartmentHandlers
{
    public class GetDepartmentQueryHandler : IRequestHandler<GetDepartmentQuery, List<GetDepartmentResult>>
    {
        private readonly IRepository<Department> _repository;

        public GetDepartmentQueryHandler(IRepository<Department> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetDepartmentResult>> Handle(GetDepartmentQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetAllAsync();
            return  value.Select(x=>new GetDepartmentResult
            {
                DepartmentId=x.DepartmentId,
                Name=x.Name,
            }).ToList();
        }
    }
}

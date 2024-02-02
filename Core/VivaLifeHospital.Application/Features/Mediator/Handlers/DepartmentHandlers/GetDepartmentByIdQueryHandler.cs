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
    public class GetDepartmentByIdQueryHandler : IRequestHandler<GetDepartmentByIdQuery, GetDepartmentByIdResult>
    {
        private readonly IRepository<Department> _repository;

        public GetDepartmentByIdQueryHandler(IRepository<Department> repository)
        {
            _repository = repository;
        }

        public async Task<GetDepartmentByIdResult> Handle(GetDepartmentByIdQuery request, CancellationToken cancellationToken)
        {
            var value = await _repository.GetByIdAsync(request.Id);
            return new GetDepartmentByIdResult
            {
                DepartmentId = value.DepartmentId,
                Name = value.Name,
            };
        }
    }
}

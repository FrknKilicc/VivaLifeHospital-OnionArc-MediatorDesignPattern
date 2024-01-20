﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Application.Features.Mediator.Results.DoctorResult;

namespace VivaLifeHospital.Application.Features.Mediator.Queries.DoctorQueries
{
    public class GetAllDoctorWithDepartmentQuery:IRequest<List<GetAllDoctorWithDepartmentResult>>
    {
    }
}

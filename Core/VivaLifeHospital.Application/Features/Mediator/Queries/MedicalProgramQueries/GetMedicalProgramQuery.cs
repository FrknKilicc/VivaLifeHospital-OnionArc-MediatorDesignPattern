﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Application.Features.Mediator.Results.MedicalProgramResult;

namespace VivaLifeHospital.Application.Features.Mediator.Queries.MedicalProgramQueries
{
    public class GetMedicalProgramQuery:IRequest<List<GetMedicalProgramResult> >
    {
    }
}

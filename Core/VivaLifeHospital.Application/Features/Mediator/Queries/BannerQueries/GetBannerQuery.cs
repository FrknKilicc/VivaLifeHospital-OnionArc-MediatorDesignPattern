﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Application.Features.Mediator.Results.BannerResult;

namespace VivaLifeHospital.Application.Features.Mediator.Queries.BannerQueries
{
    public class GetBannerQuery:IRequest<List<GetBannerResult>>
    {
    }
}

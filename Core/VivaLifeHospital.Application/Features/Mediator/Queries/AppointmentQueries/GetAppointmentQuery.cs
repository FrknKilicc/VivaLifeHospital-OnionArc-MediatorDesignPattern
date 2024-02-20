using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Application.Features.Mediator.Results.AppointmentResult;

namespace VivaLifeHospital.Application.Features.Mediator.Queries.AppointmentQueries
{
    public class GetAppointmentQuery:IRequest<List<GetAppointmentResult>>
    {

    }
}

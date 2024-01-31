﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLifeHospital.Application.Features.Mediator.Commands.BannerCommands
{
    public class CreateBannerCommand:IRequest
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string BannerImageUrl { get; set; }
    }
}

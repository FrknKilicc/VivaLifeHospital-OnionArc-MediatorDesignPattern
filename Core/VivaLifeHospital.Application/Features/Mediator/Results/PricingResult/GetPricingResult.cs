﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLifeHospital.Application.Features.Mediator.Results.PricingResult
{
    public class GetPricingResult
    {
        public int PricingId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}

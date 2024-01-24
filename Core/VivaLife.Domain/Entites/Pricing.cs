﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLife.Domain.Entites
{
    public class Pricing
    {
        public int PricingId { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
    }
}

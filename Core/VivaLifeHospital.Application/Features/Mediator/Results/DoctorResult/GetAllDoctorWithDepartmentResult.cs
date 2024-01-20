﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLifeHospital.Application.Features.Mediator.Results.DoctorResult
{
    public class GetAllDoctorWithDepartmentResult
    {
        public int DoctorId { get; set; }
        public string DoctorImgUrl { get; set; }
        public string Name { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        public int DepartmentId { get; set; }
    }
}

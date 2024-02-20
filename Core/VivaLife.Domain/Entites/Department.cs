﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLife.Domain.Entites
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public List<Doctor> Doctor { get; set; }
        public List<Appointment> Appointment { get; set; }
    }
}

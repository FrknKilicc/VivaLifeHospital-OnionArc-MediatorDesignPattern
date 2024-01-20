using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Interfaces.DoctorInterfaces;
using VivaLifeHospital.Persistance.Context;

namespace VivaLifeHospital.Persistance.Repositories.DoctorRepositories
{
    public class DoctorRepository : IDoctorRepository
    {
        private readonly VivaLifeHospitalContext _context;

        public DoctorRepository(VivaLifeHospitalContext context)
        {
            _context = context;
        }

        public List<Doctor> GetAllDoctorWithDeparment()
        {
            var values = _context.Doctors.Include(x=>x.Department).ToList();
            return values;
        }
    }
}

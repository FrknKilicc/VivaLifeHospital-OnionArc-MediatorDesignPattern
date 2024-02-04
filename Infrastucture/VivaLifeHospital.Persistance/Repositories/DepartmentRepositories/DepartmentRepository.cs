using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Interfaces.DepartmentInterfaces;
using VivaLifeHospital.Persistance.Context;

namespace VivaLifeHospital.Persistance.Repositories.DepartmentRepositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly VivaLifeHospitalContext _context;

        public DepartmentRepository(VivaLifeHospitalContext context)
        {
            _context = context;
        }
       
        public List<Doctor> GetDepartmentWithDoctor(int id)
        {
            return _context.Doctors.Include(x=>x.Department)
            .Where(d => d.DepartmentId == id)
            .ToList();

        }

        public async Task<List<Doctor>> GetDoctorByFilterAsync(Expression<Func<Doctor, bool>> filter)
        {
            var values = await _context.Doctors.Where(filter).ToListAsync();
            return values.ToList();
        }
    }
}

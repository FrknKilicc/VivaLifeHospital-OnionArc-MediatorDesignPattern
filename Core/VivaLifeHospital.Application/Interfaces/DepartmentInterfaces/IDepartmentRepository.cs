using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;

namespace VivaLifeHospital.Application.Interfaces.DepartmentInterfaces
{
    public interface IDepartmentRepository
    {
        public List<Doctor> GetDepartmentWithDoctor(int id);
        public  Task<List<Doctor>> GetDoctorByFilterAsync(Expression<Func<Doctor, bool>> filter);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;

namespace VivaLifeHospital.Application.Interfaces.DoctorInterfaces
{
    public interface IDoctorRepository
    {
        public List<Doctor> GetAllDoctorWithDeparment();
        public List<Doctor> GetDoctorWithDepartmentBySearch(int id,string search);
    }
}

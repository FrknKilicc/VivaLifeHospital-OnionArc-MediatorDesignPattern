using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;

namespace VivaLifeHospital.Application.Interfaces.MedicalProgramInterfaces
{
    public interface IMedicalProgramRepository
    {
        public List<MedicalProgram> MedicalProgramWithPrice();
    }
}

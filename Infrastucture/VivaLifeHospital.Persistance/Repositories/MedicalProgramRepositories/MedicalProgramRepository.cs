using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Interfaces.MedicalProgramInterfaces;
using VivaLifeHospital.Persistance.Context;

namespace VivaLifeHospital.Persistance.Repositories.MedicalProgramRepositories
{
    public class MedicalProgramRepository : IMedicalProgramRepository
    {
        private readonly VivaLifeHospitalContext _context;

        public MedicalProgramRepository(VivaLifeHospitalContext context)
        {
            _context = context;
        }

        public List<MedicalProgram> MedicalProgramWithPrice()
        {
            var value = _context.MedicalPrograms.Include(x => x.Pricing).ToList();
            return value;
        }
    }
}

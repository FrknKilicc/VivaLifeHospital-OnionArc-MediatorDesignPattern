using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLifeHospital.Application.Interfaces;
using VivaLifeHospital.Persistance.Context;

namespace VivaLifeHospital.Persistance.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly VivaLifeHospitalContext _context;

        public Repository(VivaLifeHospitalContext context)
        {
            _context = context;
        }

        public async Task CreateAsync(T entity)
        {
          await _context.Set<T>().AddAsync(entity);
          await _context.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
          return await _context.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
            _context.Set<T>().Remove(entity);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _context.Set<T>().Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}

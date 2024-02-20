using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Interfaces.BlogInterfaces;
using VivaLifeHospital.Persistance.Context;

namespace VivaLifeHospital.Persistance.Repositories.BlogRepositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly VivaLifeHospitalContext _context;

        public BlogRepository(VivaLifeHospitalContext context)
        {
            _context = context;
        }

        public List<Blog> GetBlogsWithAuthorNdCategory()
        {
            var value = _context.Blogs.Include(x=>x.Author).Include(x=>x.Category).ToList();
            return value;
        }
      
        public List<Blog> GetLast3BlogsWithAuthorNdCategory()
        {

            var value = _context.Blogs.Include(x => x.Author).Include(y => y.Category).OrderByDescending(z => z.BlogId).Take(3).ToList();
            return value;
        }
    }
}

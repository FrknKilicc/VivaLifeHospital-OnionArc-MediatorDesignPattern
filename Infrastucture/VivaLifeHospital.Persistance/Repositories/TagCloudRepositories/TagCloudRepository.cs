using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Interfaces.TagCloudInterfaces;
using VivaLifeHospital.Persistance.Context;

namespace VivaLifeHospital.Persistance.Repositories.TagCloudRepositories
{
    public class TagCloudRepository : ITagCloudRepository
    {
        private readonly VivaLifeHospitalContext _context;

        public TagCloudRepository(VivaLifeHospitalContext context)
        {
            _context = context;
        }
        public List<TagCloud> GetTagCloudByBlogId(int id)
        {
            var value = _context.TagsCloud.Where(y=>y.BlogId==id).ToList();
            return value;
        }
      
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;
using VivaLifeHospital.Application.Interfaces.CommentInterfaces;
using VivaLifeHospital.Persistance.Context;

namespace VivaLifeHospital.Persistance.Repositories.CommentRepositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly VivaLifeHospitalContext _context;

        public CommentRepository(VivaLifeHospitalContext context)
        {
            _context = context;
        }

        public List<Comment> GetCommentByBlogId(int id)
        {
            var values = _context.Comments.Where(x => x.BlogId == id).ToList();
            return values;
        }
    }
}

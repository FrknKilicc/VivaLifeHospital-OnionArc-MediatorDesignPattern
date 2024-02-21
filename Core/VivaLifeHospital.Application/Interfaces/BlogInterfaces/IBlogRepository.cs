using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;

namespace VivaLifeHospital.Application.Interfaces.BlogInterfaces
{
    public interface IBlogRepository
    {
        public  List<Blog> GetBlogsWithAuthorNdCategory();
        public List<Blog> GetLast3BlogsWithAuthorNdCategory();
        public Blog GetBlogByIdWithAuthor(int id);
        List<Blog> GetBlogsBySearch(string keyword);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VivaLife.Domain.Entites;

namespace VivaLifeHospital.Application.Interfaces.CommentInterfaces
{
    public interface ICommentRepository
    {
        List<Comment> GetCommentByBlogId(int id);
    }
}

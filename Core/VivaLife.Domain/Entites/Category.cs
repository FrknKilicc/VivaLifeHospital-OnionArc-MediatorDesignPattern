using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLife.Domain.Entites
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<Blog> Blogs { get; set; }
    }
}

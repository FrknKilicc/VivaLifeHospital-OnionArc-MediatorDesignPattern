using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLife.Domain.Entites
{
    public class TagCloud
    {
        public int TagCloudId { get; set; }
        public string TagName { get; set; }
        public string  BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace VivaLife.Domain.Entites
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string BlogImgUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int AuthorId { get; set; }
        public Author Author { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
      
        public List<TagCloud>? Tags { get; set; }
        
        public List<Comment>? Comments { get; set; } 
    }
}

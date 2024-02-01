using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLifeHospital.Dto.BlogDtos
{
    public  class ResultBlogDto
    {
        public int BlogId { get; set; }
        public string BlogImgUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
    }
}

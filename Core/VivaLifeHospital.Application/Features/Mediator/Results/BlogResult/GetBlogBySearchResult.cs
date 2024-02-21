using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLifeHospital.Application.Features.Mediator.Results.BlogResult
{
    public class GetBlogBySearchResult
    {
        public int BlogId { get; set; }
        public string BlogImgUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDateTime { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }
        public string AuthorImg { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}

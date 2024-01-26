using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLifeHospital.Application.Features.Mediator.Results.AuthorResult
{
    public class GetAuthorResult
    {
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AuthorImgUrl { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLifeHospital.Application.Features.Mediator.Results.AboutResult
{
    public class GetAboutResult
    {
        public int AboutId { get; set; }
        public string AboutImageUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}

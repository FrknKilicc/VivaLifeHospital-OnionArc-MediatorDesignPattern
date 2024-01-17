using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLife.Domain.Entites
{
    public class MedicalProgram
    {
        public int MedicalProgramId { get; set; }
        public string MedicalProgramCoverImgUrl { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int PricingId { get; set; }
        public Pricing Pricing { get; set; }
    }
}

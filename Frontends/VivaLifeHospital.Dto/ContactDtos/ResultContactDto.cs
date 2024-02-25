using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLifeHospital.Dto.ContactDtos
{
    public class ResultContactDto
    {
  
        public int ContactId { get; set; }
        public string ContactAddress { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string ContactMail { get; set; }
    }
}

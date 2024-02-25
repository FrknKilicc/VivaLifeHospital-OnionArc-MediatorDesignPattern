using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLife.Domain.Entites
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        public string ContactAddress { get; set; }
        public string ContactPhoneNumber { get; set; }
        [EmailAddress]
        public string ContactMail { get; set; }
    }
}

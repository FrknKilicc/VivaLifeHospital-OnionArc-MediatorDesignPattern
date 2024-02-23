using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaLifeHospital.Dto.CommentDtos
{
    public class CreateCommentDto
    {
        public int CommentId { get; set; }
        [StringLength(50)]
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
       
        [StringLength(500)]
        public string Description { get; set; }
        public int BlogId { get; set; }
        //parametresiz consctrc.
        public CreateCommentDto()
        {
            CreatedDate = DateTime.Now;
        }
        //parametreli consctrc.
        public CreateCommentDto(DateTime createdDate)
        {
            CreatedDate = createdDate;
        }

    }
}

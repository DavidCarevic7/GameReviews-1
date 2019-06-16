using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.DTO
{
    public class CreateCommentDto
    {
        public int Id { get; set; }
        [Required]
        public string Text { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int PostId { get; set; }

    }
}

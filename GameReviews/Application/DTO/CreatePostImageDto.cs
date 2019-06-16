using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.DTO
{
    public class CreatePostImageDto
    {
        public int Id { get; set; }
        [Required]
        public string ImageName { get; set; }
    }
}

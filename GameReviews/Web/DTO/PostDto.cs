using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.DTO
{
    public class PostDto
    {
        public int Id { get; set; }

        [MinLength(1, ErrorMessage = "Title must be filled"), MaxLength(50, ErrorMessage = "Max lenght is 50")]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }

        [RegularExpression(@"^[1-5]{1}$", ErrorMessage = "Ratings are 1 to 5")]
        public int Rating { get; set; }

        public int PostImageId { get; set; }
        [Required]
        public IFormFile PostImage { get; set; }
        [Required]
        public int UserId { get; set; }
    }
}

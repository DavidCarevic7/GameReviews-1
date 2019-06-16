using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTO
{
   public  class GetPostDto
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public int Rating { get; set; }

        public int PostImageId { get; set; }

        public int UserId { get; set; }

        public string ImageName { get; set; }

        

        

    }
}

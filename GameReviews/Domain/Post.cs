using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Post:BaseEntity
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public int Rating { get; set; }

        public int PostImageId { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }

        public PostImage PostImage { get; set; }

        public ICollection<Comment> Comments { get; set; }
       
    }
}

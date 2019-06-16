using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class PostImage:BaseEntity
    {

        public string ImageName { get; set; }

        

        public Post Post { get; set; }
    }
}

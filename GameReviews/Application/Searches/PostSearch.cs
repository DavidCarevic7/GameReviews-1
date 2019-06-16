using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Searches
{
    public class PostSearch
    {
        public string Title { get; set; }

        public int PageNumber { get; set; } = 1;
        public int PerPage { get; set; } = 2;
    }
}

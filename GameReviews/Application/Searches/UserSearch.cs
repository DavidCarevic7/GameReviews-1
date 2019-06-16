using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Searches
{
    public class UserSearch
    {
        public string Email { get; set; }
        public int PageNumber { get; set; } = 1;
        public int PerPage { get; set; } = 2;
    }
}

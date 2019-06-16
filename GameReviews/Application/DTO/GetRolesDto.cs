using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTO
{
    public class GetRolesDto
    {

        public int Id { get; set; }
        public string RoleName { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }
    }
}

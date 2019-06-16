using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.DTO
{
    public class CreateRoleDto
    {
        public int Id { get; set; }
        [MinLength(2, ErrorMessage = "Role name must be filled")]
        public string RoleName { get; set; }

    }
}

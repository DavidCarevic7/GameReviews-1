using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Application.DTO
{
    public class CreateUserDto
    {
        public int Id { get; set; }
        
        [EmailAddress]
        public string Email { get; set; }
        [RegularExpression(@"^[A-z\d]{3,}$", ErrorMessage = "Your password is too short")]
        public string Password { get; set; }

        [RegularExpression(@"^[A-z]{2,}$",ErrorMessage ="The name is too short")]
        public string FirstName { get; set; }
        [RegularExpression(@"^[A-z]{2,}$", ErrorMessage = "The lastname is too short")]
        public string LastName { get; set; }
        [RegularExpression(@"^[1-9]{1}$",ErrorMessage="The role doesn't exist")]
        public int RoleId { get; set; }
    }
}

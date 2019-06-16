using Application.Commands;
using Application.DTO;
using Application.Exceptions;
using EfDataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EfCommands
{
    public class LoginCommand : BaseEFCommand, IAuthorizeCommand
    {
        public LoginCommand(GamesContext context) : base(context)
        {
        }

        public GetUserDto Execute(LoginDto request)
        {
            var user = _context.Users.Include(u => u.Role).Where(u => u.Email == request.Email && u.Password == request.Password).FirstOrDefault();

            if (user == null)
                throw new EntityNotFoundException("User");

            return new GetUserDto
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                Email = user.Email,
                Id = user.Id,
                RoleName = user.Role.RoleName
            };
        }
    }
}

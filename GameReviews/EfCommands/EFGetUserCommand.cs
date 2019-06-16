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
    public class EFGetUserCommand : BaseEFCommand, IGetUserCommand
    {
        public EFGetUserCommand(GamesContext context) : base(context)
        {
        }

        public GetUserDto Execute(int request)
        {

            var user = _context.Users.Where(u=>u.Id==request).Include(u=>u.Role).First();

            if (user == null || user.IsDeleted == true) { throw new EntityNotFoundException("User"); }

            return new GetUserDto {
                Email = user.Email,
                Id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName,
                RoleId = user.RoleId,
                CreatedOn = user.CreatedOn,
                ModifiedOn = user.ModifiedOn,
                RoleName = user.Role.RoleName

                 
                
            };
        }
    }
}

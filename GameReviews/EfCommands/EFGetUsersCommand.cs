using Application.Commands;
using Application.DTO;
using Application.Exceptions;
using Application.Searches;
using EfDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EfCommands
{
    public class EFGetUsersCommand : BaseEFCommand, IGetUsersCommand
    {
        public EFGetUsersCommand(GamesContext context) : base(context)
        {
        }

        public IEnumerable<GetUserDto> Execute(UserSearch request)
        {
            var query = _context.Users.Where(r => r.IsDeleted == false).AsQueryable();

            if (request.Email != null)
            {
                if (!query.Any(r => r.Email.ToLower().Contains(request.Email.ToLower())))
                {
                    throw new EntityNotFoundException("User");
                }

                query = query.Where(r => r.Email.ToLower().Contains(request.Email.ToLower()));



            }

            return query.Select(r => new GetUserDto
            {

                Email = r.Email,
                Id = r.Id,
                FirstName = r.FirstName,
                LastName = r.LastName,
                RoleId = r.RoleId,
                CreatedOn = r.CreatedOn,
                ModifiedOn = r.ModifiedOn,
                RoleName=r.Role.RoleName

                



            });
        }
    }
}

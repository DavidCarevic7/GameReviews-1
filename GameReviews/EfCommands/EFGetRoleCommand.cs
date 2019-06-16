using Application.Commands;
using Application.DTO;
using Application.Exceptions;
using EfDataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace EfCommands
{
    public class EFGetRoleCommand : BaseEFCommand, IGetRoleComand
    {
        public EFGetRoleCommand(GamesContext context) : base(context)
        {
        }

        public GetRolesDto Execute(int request)
        {
            var role = _context.Roles.Find(request);

            if (role == null || role.IsDeleted==true) { throw new EntityNotFoundException("Role"); }
            

            return new GetRolesDto
            {
                Id = role.Id,
                CreatedOn = role.CreatedOn,
                ModifiedOn = role.ModifiedOn,
                RoleName = role.RoleName
            };
        }
    }
}

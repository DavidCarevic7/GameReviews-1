using Application.Commands;
using Application.DTO;
using Application.Exceptions;
using EfDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EfCommands
{
    public class EFEditRoleCommand : BaseEFCommand, IEditRoleCommand
    {
        public EFEditRoleCommand(GamesContext context) : base(context)
        {
        }

        public void Execute(CreateRoleDto request)
        {
            var role = _context.Roles.Find(request.Id);

            if (role == null || role.IsDeleted==true) { throw new EntityNotFoundException("Role"); }
            if (_context.Roles.Any(r => r.RoleName.Contains(request.RoleName))) { throw new EntityAlreadyExistsException("Role"); }

            role.IsDeleted = role.IsDeleted;
            role.ModifiedOn = DateTime.Now;
            role.CreatedOn = role.CreatedOn;
            role.RoleName = request.RoleName;

            _context.SaveChanges();


            
        }
    }
}

using Application.Commands;
using Application.DTO;
using Application.Exceptions;
using Domain;
using EfDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EfCommands
{
    public class EFCreateRoleCommand : BaseEFCommand, IAddRoleCommand
    {
        public EFCreateRoleCommand(GamesContext context) : base(context)
        {
        }

        public void Execute(CreateRoleDto request)
        {
            
            
                if (_context.Roles.Any(r => r.RoleName.ToLower().Contains(request.RoleName.ToLower())))
                {

                    throw new EntityAlreadyExistsException("This role ");

                }
               

                _context.Roles.Add(new Role
                {
                    RoleName = request.RoleName,
                    ModifiedOn = null,
                    IsDeleted = false
                });

                _context.SaveChanges();
            

            
        }
    }
}

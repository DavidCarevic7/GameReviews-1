using Application.Commands;
using Application.Exceptions;
using EfDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EfCommands
{
    public class EFDeleteRoleCommand : BaseEFCommand, IDeleteRoleCommand
    {
        public EFDeleteRoleCommand(GamesContext context) : base(context)
        {
        }

        public void Execute(int request)
        {

            var role = _context.Roles.Find(request);

            if (role == null) { throw new EntityNotFoundException("Role"); }

            role.IsDeleted = true;

            _context.SaveChanges();


        }
    }
}

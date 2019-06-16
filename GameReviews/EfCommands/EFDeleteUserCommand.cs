using Application.Commands;
using Application.Exceptions;
using EfDataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace EfCommands
{
    public class EFDeleteUserCommand : BaseEFCommand, IDeleteUserCommand
    {
        public EFDeleteUserCommand(GamesContext context) : base(context)
        {
        }

        public void Execute(int request)
        {
            var user = _context.Users.Find(request);
            if (user == null) { throw new EntityNotFoundException("User"); }

            user.IsDeleted = true;

            _context.SaveChanges();

        }
    }
}

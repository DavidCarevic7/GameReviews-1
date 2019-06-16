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
    public class EFEditUserCommand : BaseEFCommand, IEditUserCommand
    {
        public EFEditUserCommand(GamesContext context) : base(context)
        {
        }

        public void Execute(CreateUserDto request)
        {

            var user = _context.Users.Find(request.Id);

            if (user == null || user.IsDeleted==true) { throw new EntityNotFoundException("User"); }
            if (request.Email != user.Email)
            {
                if (_context.Users.Any(u => u.Email.Contains(request.Email))) { throw new EntityAlreadyExistsException("Email"); }
            }

            user.IsDeleted = user.IsDeleted;
            user.ModifiedOn = DateTime.Now;
            user.CreatedOn = user.CreatedOn;
            user.FirstName = request.FirstName;
            user.LastName = request.LastName;
            user.Email = request.Email;
            user.Password = request.Password;
            user.RoleId = request.RoleId;

            _context.SaveChanges();

        }
    }
}

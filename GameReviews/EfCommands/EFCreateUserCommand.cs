
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
    public class EFCreateUserCommand : BaseEFCommand, ICreateUserCommand
    {
        public EFCreateUserCommand(GamesContext context) : base(context)
        {
        }

        public void Execute(CreateUserDto request)
        {
            if (_context.Users.Any(u => u.Email.ToLower().Contains(request.Email.ToLower())))
            {

                throw new EntityAlreadyExistsException("This user ");

            }

            _context.Users.Add(new User
            {

                Email = request.Email,
                Password = request.Password,
                FirstName = request.FirstName,
                LastName = request.LastName,
                RoleId = request.RoleId,
                ModifiedOn = null,
                IsDeleted = false




            });

            _context.SaveChanges();



        }
    }
}

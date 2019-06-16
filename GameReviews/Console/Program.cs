using System;
using EfDataAccess;
using Domain;

namespace Console
{
    public class Program
    {
     
        static void Main(string[] args)
        {
            var context = new GamesContext();
            context.Roles.Add(new Role {
                  IsDeleted=false,
                  RoleName="Admin",
                  ModifiedOn=null
            });
            context.Roles.Add(new Role
            {
                IsDeleted = false,
                RoleName = "Journalist",
                ModifiedOn = null
            });
            context.Roles.Add(new Role
            {
                IsDeleted = false,
                RoleName = "User",
                ModifiedOn = null
            });

            context.Users.Add(new User
            {
                Email = "david.carevic.159.14@ict.edu.rs",
                Password = "david",
                FirstName = "David",
                LastName = "Carevic",
                ModifiedOn = null,
                IsDeleted = false,
                RoleId = 1

            });
            context.SaveChanges();






        }

    }
}
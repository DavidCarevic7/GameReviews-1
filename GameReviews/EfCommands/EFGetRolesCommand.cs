using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Application.Commands;
using Application.DTO;
using Application.Exceptions;
using Application.Searches;
using EfDataAccess;

namespace EfCommands
{
    public class EFGetRolesCommand : BaseEFCommand,IGetRolesCommand
    {
        public EFGetRolesCommand(GamesContext context) : base(context)
        {
        }

        public IEnumerable<GetRolesDto> Execute(RoleSearch request)
        {
            var query = _context.Roles.Where(r=>r.IsDeleted==false).AsQueryable();

            if (request.RoleName != null) {
                if (!query.Any(r => r.RoleName.ToLower().Contains(request.RoleName.ToLower())))
                {
                    throw new EntityNotFoundException("Role");
                }
                
                    query = query.Where(r => r.RoleName.ToLower().Contains(request.RoleName.ToLower()));
                
                
                
            }

            return query.Select(r=>new GetRolesDto {
                Id=r.Id,
                RoleName=r.RoleName,
                CreatedOn=r.CreatedOn,
                ModifiedOn=r.ModifiedOn

            });

        }
    }
}

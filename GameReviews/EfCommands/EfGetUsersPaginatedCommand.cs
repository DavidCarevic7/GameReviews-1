using Application.Commands;
using Application.DTO;
using Application.Exceptions;
using Application.Responses;
using Application.Searches;
using EfDataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EfCommands
{
    public class EfGetUsersPaginatedCommand : BaseEFCommand, IGetUsersPaginatedCommand
    {
        public EfGetUsersPaginatedCommand(GamesContext context) : base(context)
        {
        }

        public PagedResponse<GetUserDto> Execute(UserSearch request)
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

            var totalCount = query.Count();
            query = query.Include(u => u.Role).Skip((request.PageNumber - 1) * request.PerPage).Take(request.PerPage);

            var pagesCount = (int)Math.Ceiling((double)totalCount / request.PerPage);

            var response = new PagedResponse<GetUserDto>
            {
                PagesCount = pagesCount,
                CurrentPage = request.PageNumber,
                TotalCount = totalCount,
                Data = query.Select(r => new GetUserDto
                {
                    Email = r.Email,
                    Id = r.Id,
                    FirstName = r.FirstName,
                    LastName = r.LastName,
                    RoleId = r.RoleId,
                    CreatedOn = r.CreatedOn,
                    ModifiedOn = r.ModifiedOn,
                    RoleName = r.Role.RoleName
                })
            };
            return response;
            }
    }
}

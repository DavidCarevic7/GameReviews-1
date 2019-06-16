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
    public class EFGetPostsPaginatedCommand : BaseEFCommand, IGetPostsPaginatedCommand
    {
        public EFGetPostsPaginatedCommand(GamesContext context) : base(context)
        {
        }

        public PagedResponse<GetPostDto> Execute(PostSearch request)
        {
            var query = _context.Posts.Where(r => r.IsDeleted == false).AsQueryable();

            if (request.Title != null)
            {
                if (!query.Any(r => r.Title.ToLower().Contains(request.Title.ToLower())))
                {
                    throw new EntityNotFoundException("Post");
                }

                query = query.Where(r => r.Title.ToLower().Contains(request.Title.ToLower()));

            }

            var totalCount = query.Count();
            query = query.Include(s=>s.PostImage).Skip((request.PageNumber - 1) * request.PerPage).Take(request.PerPage);

            var pagesCount = (int)Math.Ceiling((double)totalCount / request.PerPage);

            var response = new PagedResponse<GetPostDto>
            {
                PagesCount = pagesCount,
                CurrentPage = request.PageNumber,
                TotalCount = totalCount,
                Data = query.Select(r => new GetPostDto
                {
                   Id=r.Id,
                   Title=r.Title,
                   Description=r.Description,
                   ImageName=r.PostImage.ImageName,
                   PostImageId=r.PostImageId,
                   Rating=r.Rating,
                   UserId=r.UserId
                })
            };
            return response;
        }
    }
}

using Application.Commands;
using Application.DTO;
using Application.Exceptions;
using Application.Searches;
using EfDataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EfCommands
{
    public class EFGetPostsCommand : BaseEFCommand, IGetPostsCommand
    {
        public EFGetPostsCommand(GamesContext context) : base(context)
        {
        }

        public IEnumerable<GetPostDto> Execute(PostSearch request)
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

            return query.Select(r => new GetPostDto
            {
                Description=r.Description,
                Id=r.Id,
                ImageName=r.PostImage.ImageName,
                PostImageId=r.PostImageId,
                Rating=r.Rating,
                Title=r.Title,
                UserId=r.UserId
            
                

            });

        }
    }
}

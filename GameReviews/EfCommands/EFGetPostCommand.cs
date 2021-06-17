using Application.Commands;
using Application.DTO;
using Application.Exceptions;
using EfDataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EfCommands
{
    public class EFGetPostCommand : BaseEFCommand, IGetPostCommand
    {
        public EFGetPostCommand(GamesContext context) : base(context)
        {
        }

        public GetOnePostDto Execute(int request)
        {
            var post = _context.Posts
                .Where(p=>p.Id==request && p.IsDeleted==false)
                .Include(p => p.PostTags).ThenInclude(p=>p.Tag)
                .Include(p=>p.PostImage)
                .Include(p => p.User)
                .Include(p => p.Comments)
                .ThenInclude(c => c.User).First();

            if (post == null)
                throw new EntityNotFoundException();

            return new GetOnePostDto
            {
                Id=post.Id,
                Rating=post.Rating,
                Description=post.Description,
                ImageName=post.PostImage.ImageName,
                Title=post.Title,
                Email=post.User.Email,
                Comments=post.Comments.Select(c=>new GetCommentDto
                {
                    Text=c.Text,
                    FirstName=c.User.FirstName,
                    LastName=c.User.LastName
                    
                }).ToList(),

                Tags=post.PostTags.Select(c=> new GetTagsDto { 
                    Name=c.Tag.Name
                }).ToList()

                
            };
            
        }
    }
}

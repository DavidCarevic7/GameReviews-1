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
    public class EFCreatePostCommand : BaseEFCommand, ICreatePostCommand
    {
        public EFCreatePostCommand(GamesContext context) : base(context)
        {
        }

        public void Execute(CreatePostDto request)
        {
            if (_context.Posts.Any(r => r.PostImageId==request.PostImageId))
            {

                throw new EntityAlreadyExistsException("This post ");

            }


            _context.Posts.Add(new Post
            {
                Description=request.Description,
                PostImageId=request.PostImageId,
                Rating=request.Rating,
                Title=request.Title,
                 UserId=request.UserId,
                ModifiedOn = null,
                IsDeleted = false
            });

            _context.SaveChanges();
        }
    }
}

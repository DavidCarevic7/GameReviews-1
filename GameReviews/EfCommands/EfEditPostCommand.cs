using Application.Commands;
using Application.DTO;
using Application.Exceptions;
using EfDataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace EfCommands
{
    public class EfEditPostCommand : BaseEFCommand, IEditPostCommand
    {
        public EfEditPostCommand(GamesContext context) : base(context)
        {
        }

        public void Execute(CreatePostDto request)
        {

            var post = _context.Posts.Find(request.Id);
            if (post==null || post.IsDeleted==true)
            {

                throw new EntityNotFoundException("Post");

            }


            post.Description = request.Description;
            post.Title = request.Title;
            post.Rating = request.Rating;
            post.ModifiedOn = DateTime.Now;
            
            


            _context.SaveChanges();
        }
    }
}

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
    public class EFCreateCommentCommand : BaseEFCommand, ICreateCommentCommand
    {
        public EFCreateCommentCommand(GamesContext context) : base(context)
        {
        }

        public void Execute(CreateCommentDto request)
        {
            if (!_context.Users.Any(r => r.Id==request.UserId))
            {

                throw new EntityNotFoundException("User ");

            }
            if (!_context.Posts.Any(r => r.Id == request.PostId))
            {

                throw new EntityNotFoundException("Post ");

            }


            _context.Commnets.Add(new Comment
            {
                PostId = request.PostId,
                UserId = request.UserId,
                Text = request.Text,
                ModifiedOn = null,
                IsDeleted = false
            });

            _context.SaveChanges();
        }
    }
}

using Application.Commands;
using Application.DTO;
using Application.Exceptions;
using Application.Interfaces;
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
        private readonly IEmailSender _emailSender;
        public EFCreateCommentCommand(GamesContext context,IEmailSender s) : base(context)
        {
            _emailSender = s;

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

            var email = _context.Commnets.Where(p => p.UserId == request.UserId).Select(u => u.User.Email).First().ToString();
            _emailSender.Subject = "Comment posted!";
            _emailSender.Body = "Your Comment was created! Yey!";
            _emailSender.ToEmail = email;
            _emailSender.Send();
        }
    }
}

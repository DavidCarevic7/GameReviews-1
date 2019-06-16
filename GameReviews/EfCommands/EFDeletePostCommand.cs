using Application.Commands;
using Application.Exceptions;
using EfDataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace EfCommands
{
    public class EFDeletePostCommand : BaseEFCommand, IDeletePostCommand
    {
        public EFDeletePostCommand(GamesContext context) : base(context)
        {
        }

        public void Execute(int request)
        {
            var post = _context.Posts.Find(request);

            if (post == null)
                throw new EntityNotFoundException("Post");

            post.IsDeleted = true;
            _context.SaveChanges();
        }
    }
}

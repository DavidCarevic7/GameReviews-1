using Application.Commands;
using Application.Exceptions;
using EfDataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace EfCommands
{
    public class EFDeleteCommentCommand : BaseEFCommand, IDeleteCommentCommand
    {
        public EFDeleteCommentCommand(GamesContext context) : base(context)
        {
        }

        public void Execute(int request)
        {
            var comment = _context.Commnets.Find(request);

            if (comment == null)
                throw new EntityNotFoundException("Comment");

            comment.IsDeleted = true;
            _context.SaveChanges();
        }
    }
}

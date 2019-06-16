using Application.Commands;
using Application.DTO;
using Application.Exceptions;
using EfDataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace EfCommands
{
    public class EFEditCommentCommand : BaseEFCommand, IEditCommentCommand
    {
        public EFEditCommentCommand(GamesContext context) : base(context)
        {
        }

        public void Execute(EditCommentDto request)
        {
            var comment = _context.Commnets.Find(request.Id);

            if (comment == null)
                throw new EntityNotFoundException("Comment");


            comment.Text = request.Text;
            comment.ModifiedOn = DateTime.Now;
                     
            _context.SaveChanges();
        }
    }
}

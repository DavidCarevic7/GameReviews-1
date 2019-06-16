using Application.Commands;
using Application.DTO;
using Application.Exceptions;
using EfDataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace EfCommands
{
    public class EFGetCommentCommand : BaseEFCommand, IGetCommentCommand
    {
        public EFGetCommentCommand(GamesContext context) : base(context)
        {
        }

        public CreateCommentDto Execute(int request)
        {
            var comment = _context.Commnets.Find(request);

            if (comment == null)
            {
                throw new EntityNotFoundException("Comment");
            }

            return new CreateCommentDto
            {
                PostId=comment.PostId,
                UserId=comment.UserId,
                Text=comment.Text
            };

        }
    }
}

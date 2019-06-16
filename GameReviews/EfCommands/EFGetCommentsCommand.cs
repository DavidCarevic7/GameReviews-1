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
    public class EFGetCommentsCommand : BaseEFCommand,IGetCommentsCommand
    {
        public EFGetCommentsCommand(GamesContext context) : base(context)
        {
        }

        public IEnumerable<CreateCommentDto> Execute(CommentSearch request)
        {
            var query = _context.Commnets.AsQueryable();

            if (request.Keyword != null)
            {
                if (!_context.Commnets.Any(c => c.Text.ToLower().Contains(request.Keyword.ToLower())))
                    throw new EntityNotFoundException("Comment");
                query = query.Where(c => c.Text.ToLower().Contains(request.Keyword.ToLower()));
            }
               

            return query.Select(c => new CreateCommentDto
            {
                PostId=c.PostId,
                UserId=c.UserId,
                Text=c.Text
            });
        }
    }
}

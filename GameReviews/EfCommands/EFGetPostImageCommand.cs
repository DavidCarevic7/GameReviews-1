using Application.Commands;
using EfDataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace EfCommands
{
    public class EFGetPostImageCommand : BaseEFCommand, IGetImageCommand
    {
        public EFGetPostImageCommand(GamesContext context) : base(context)
        {
        }

        public int Execute(int request)
        {
            var post = _context.Posts.Find(request);

            int imgId = post.PostImageId;
            return imgId;
        }
    }
}

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
    public class EFEditPostImageCommand : BaseEFCommand, IEditPostPictureCommand
    {
        public EFEditPostImageCommand(GamesContext context) : base(context)
        {
        }

        public void Execute(CreatePostImageDto request)
        {
            var image = _context.PostImages.Find(request.Id);

            if (image == null) { throw new EntityNotFoundException("Post image"); }


            image.ImageName = request.ImageName;
            image.ModifiedOn = DateTime.Now;



            _context.SaveChanges();

            


        }
    }
}

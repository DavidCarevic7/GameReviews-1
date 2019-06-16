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
    public class EFCreatePostImageCommand : BaseEFCommand, ICreateImageCommand
    {
        public EFCreatePostImageCommand(GamesContext context) : base(context)
        {
        }

        public int Execute(CreatePostImageDto request)
        {

            if (_context.PostImages.Any(r => r.ImageName.Contains(request.ImageName)))
            {

                throw new EntityAlreadyExistsException("This image ");

            }


            _context.PostImages.Add(new PostImage
            {
                ImageName=request.ImageName,
                ModifiedOn = null,
                IsDeleted = false
            });



            _context.SaveChanges();
            
             var currentImage= _context.PostImages.Where(c=>c.ImageName==request.ImageName).First();


            int id = currentImage.Id;
            

            return id;
        }
    }
}

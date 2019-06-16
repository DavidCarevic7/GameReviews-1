using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using API.DTO;
using Application.Commands;
using Application.DTO;
using Application.Exceptions;
using Application.Help;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private int imageId;
        private readonly ICreatePostCommand _postCreate;
        private readonly ICreateImageCommand _image;

        public PostsController(ICreatePostCommand postCreate, ICreateImageCommand image)
        {
            _postCreate = postCreate;
            _image = image;
        }


        // GET: api/Posts
        [HttpGet]
        public ActionResult Get()
        {
            return Ok();
        }

        // GET: api/Posts/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            return Ok();
        }

        // POST: api/Posts
        [HttpPost]
        public ActionResult Post([FromForm] PostDto dto)
        {
            var ext = Path.GetExtension(dto.PostImage.FileName);

            if (!ImageFormatCheck.AllowedExtensions.Contains(ext))
            {
                return UnprocessableEntity("Image extension is not allowed.");
            }

            try
            {
                var newFileName = Guid.NewGuid().ToString() + "_" + dto.PostImage.FileName;

                var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "PostImages", newFileName);

                dto.PostImage.CopyTo(new FileStream(filePath, FileMode.Create));

                var image = new CreatePostImageDto
                {
                    ImageName = newFileName
                };

                
                try
                {
                     this.imageId = _image.Execute(image);
                   

                }
                catch (EntityAlreadyExistsException e) { return UnprocessableEntity(e.Message); }
                catch (Exception e) { return StatusCode(500, e.Message); }





                var post = new CreatePostDto
                {
                    
                    Description = dto.Description,
                    Rating = dto.Rating,
                    Title = dto.Title,
                    UserId = dto.UserId,
                    PostImageId = this.imageId
                };


                _postCreate.Execute(post);
                return StatusCode(204);
            }
            catch (EntityAlreadyExistsException e) { return UnprocessableEntity(e.Message); }
            catch (Exception e) { return StatusCode(500, e.Message); }
        }

        // PUT: api/Posts/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

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
using Application.Searches;
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
        private readonly IGetPostsPaginatedCommand _getPosts;
        private readonly IGetPostCommand _getOne;
        private readonly IEditPostCommand _editPost;
        private readonly IGetImageCommand _getImage;
        private readonly IEditPostPictureCommand _editImage;

        public PostsController(ICreatePostCommand postCreate, ICreateImageCommand image, IGetPostsPaginatedCommand getPosts, IGetPostCommand getOne, IEditPostCommand editPost, IGetImageCommand getImage, IEditPostPictureCommand editImage)
        {
            _postCreate = postCreate;
            _image = image;
            _getPosts = getPosts;
            _getOne = getOne;
            _editPost = editPost;
            _getImage = getImage;
            _editImage = editImage;
        }









        // GET: api/Posts
        [HttpGet]
        public ActionResult Get([FromQuery]PostSearch ps)
        {
            try
            {
                var posts = _getPosts.Execute(ps);
                return Ok(posts);
            }
            catch (EntityNotFoundException e) { return NotFound(e.Message); }
            catch (Exception e) { return StatusCode(500, e.Message); }
        }

        // GET: api/Posts/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            try
            {
               var post=_getOne.Execute(id);
                return StatusCode(200, post);
            }
            catch(EntityNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch(Exception e)
            {
                return StatusCode(500, e.Message);
            }
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
                return StatusCode(201);
            }
            catch (EntityAlreadyExistsException e) { return UnprocessableEntity(e.Message); }
            catch (Exception e) { return StatusCode(500, e.Message); }
        }

        // PUT: api/Posts/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromForm] PostDto dto)
        {
            dto.Id = id;
            var imgId = _getImage.Execute(id);
            
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
                    ImageName = newFileName,
                    Id=imgId
                };


                try
                {
                     _editImage.Execute(image);


                }
                catch (EntityAlreadyExistsException e) { return UnprocessableEntity(e.Message); }
                catch (Exception e) { return StatusCode(500, e.Message); }





                var post = new CreatePostDto
                {
                    Id=dto.Id,
                    Description = dto.Description,
                    Rating = dto.Rating,
                    Title = dto.Title,
                    UserId = dto.UserId,
                    
                };


                _editPost.Execute(post);
                return StatusCode(204);
            }
            catch (EntityNotFoundException e) { return NotFound(e.Message); }
            catch (Exception e) { return StatusCode(500, e.Message); }

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

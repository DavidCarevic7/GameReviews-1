using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands;
using Application.DTO;
using Application.Exceptions;
using Application.Help;
using Application.Searches;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web.DTO;

namespace Web.Controllers
{
    public class PostsController : Controller
    {
        private int imageId;
        private readonly IGetPostsCommand _getPosts;
        private readonly IGetPostCommand _getOne;
        private readonly ICreatePostCommand _postCreate;
        private readonly ICreateImageCommand _imageCreate;
        private readonly IGetImageCommand _getImage;
        private readonly IEditPostPictureCommand _editImage;
        private readonly IEditPostCommand _editPost;
        private readonly IDeletePostCommand _deltePost;

        public PostsController(IGetPostsCommand getPosts, IGetPostCommand getOne, ICreatePostCommand postCreate, ICreateImageCommand imageCreate, IGetImageCommand getImage, IEditPostPictureCommand editImage, IEditPostCommand editPost, IDeletePostCommand deltePost)
        {
            _getPosts = getPosts;
            _getOne = getOne;
            _postCreate = postCreate;
            _imageCreate = imageCreate;
            _getImage = getImage;
            _editImage = editImage;
            _editPost = editPost;
            _deltePost = deltePost;
        }









        // GET: Posts
        public ActionResult Index([FromQuery] PostSearch ps)
        {

            try
            {
                var posts = _getPosts.Execute(ps);
                return View(posts);
            }

            catch (EntityNotFoundException e) { TempData["Error"] = e.Message; }
            catch (Exception e) { TempData["Error"] = "Server error " + e.Message; }
            return View();
        }

        // GET: Posts/Details/5
        public ActionResult Details(int id)
        {
            var post = _getOne.Execute(id);
            return View(post);
        }

        // GET: Posts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Posts/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] PostDto dto)
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
                    this.imageId = _imageCreate.Execute(image);


                }
                catch (EntityAlreadyExistsException e) { TempData["Error"]=e.Message; }
                catch (Exception e) { TempData["Error"] = e.Message; }





                var post = new CreatePostDto
                {

                    Description = dto.Description,
                    Rating = dto.Rating,
                    Title = dto.Title,
                    UserId = dto.UserId,
                    PostImageId = this.imageId
                };


                _postCreate.Execute(post);
                return RedirectToAction(nameof(Index));
            }
            catch (EntityAlreadyExistsException e) { TempData["Error"] = e.Message; }
            catch (Exception e) { TempData["Error"] = e.Message; }
            return View();
        }

        // GET: Posts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Posts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,[FromForm] PostDto dto)
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
                    Id = imgId
                };


                try
                {
                    _editImage.Execute(image);


                }
                catch (EntityAlreadyExistsException e) { TempData["Error"]=e.Message; }
                catch (Exception e) { TempData["Error"] = e.Message; }





                var post = new CreatePostDto
                {
                   Id=dto.Id,
                    Description = dto.Description,
                    Rating = dto.Rating,
                    Title = dto.Title
                    

                };


                _editPost.Execute(post);
                return RedirectToAction(nameof(Index));
            }
            catch (EntityNotFoundException e) { TempData["Error"] = e.Message; }
            catch (Exception e) { TempData["Error"] = e.Message; }
            return View();
        }

        // GET: Posts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Posts/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here


                _deltePost.Execute(id);

                return RedirectToAction(nameof(Index));
            }
            catch (EntityNotFoundException e)
            {
                TempData["Errors"] = e.Message;

            }
            catch (Exception e) { TempData["Errors"] = e.Message; }

            return View();
        }
    
    }
}
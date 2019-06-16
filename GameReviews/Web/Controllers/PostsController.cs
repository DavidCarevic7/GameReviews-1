using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands;
using Application.Exceptions;
using Application.Searches;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class PostsController : Controller
    {
        private readonly IGetPostsCommand _getPosts;
        private readonly IGetPostCommand _getOne;

        public PostsController(IGetPostsCommand getPosts, IGetPostCommand getOne)
        {
            _getPosts = getPosts;
            _getOne = getOne;
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
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Posts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Posts/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
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

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands;
using Application.DTO;
using Application.Exceptions;
using Application.Searches;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class UsersController : Controller
    {
        private readonly IGetUserCommand _getUser;
        private readonly IGetUsersCommand _getUsers;
        private readonly ICreateUserCommand _createUser;
        private readonly IEditUserCommand _editUser;
        private readonly IDeleteUserCommand _deleteUser;

        public UsersController(IGetUserCommand getUser, IGetUsersCommand getUsers, ICreateUserCommand createUser, IEditUserCommand editUser, IDeleteUserCommand deleteUser)
        {
            _getUser = getUser;
            _getUsers = getUsers;
            _createUser = createUser;
            _editUser = editUser;
            _deleteUser = deleteUser;
        }









        // GET: Users
        public ActionResult Index([FromQuery] UserSearch us)
        {

            try
            {
                var ug = _getUsers.Execute(us);
                return View(ug);
            }

            catch (EntityNotFoundException e) {  TempData["Error"]=e.Message; }
            catch (Exception e) { TempData["Error"] = "Server error "+e.Message; }
            return View();

        }

        // GET: Users/Details/5
        public ActionResult Details(int id)
        {
           var user= _getUser.Execute(id);
            return View(user);
        }

        // GET: Users/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Users/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] CreateUserDto dto)
        {
            

            try { _createUser.Execute(dto); 

                // TODO: Add insert logic here 


            return RedirectToAction(nameof(Index));
            }
            catch (EntityAlreadyExistsException e) { TempData["Error"] = e.Message; }
            catch (Exception e) { TempData["Error"] = "Server error " + e.Message; }
            return View();
        }

        // GET: Users/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Users/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, [FromForm] CreateUserDto dto)
        {
            dto.Id = id;

            try
            {
                // TODO: Add update logic here
                _editUser.Execute(dto);

                return RedirectToAction(nameof(Index));
            }
            catch (EntityAlreadyExistsException e) { TempData["Error"] = e.Message; }
            catch (EntityNotFoundException e) { TempData["Error"] = e.Message; }
            catch (Exception e) { TempData["Error"] = "Server error " + e.Message; }
            return View();

        }

        // GET: Users/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Users/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here


                _deleteUser.Execute(id);

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
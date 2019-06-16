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

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        public readonly ICreateUserCommand _userCreate;
        public readonly IEditUserCommand _userEdit;
        public readonly IGetUserCommand _userGet;
        public readonly IGetUsersCommand _usersGet;

        public UsersController(ICreateUserCommand userCreate, IEditUserCommand userEdit, IGetUserCommand userGet, IGetUsersCommand usersGet)
        {
            _userCreate = userCreate;
            _userEdit = userEdit;
            _userGet = userGet;
            _usersGet = usersGet;
        }








        // GET: api/Users
        [HttpGet]
        public ActionResult Get([FromQuery] UserSearch us)
        {
            try
            {
                var ug = _usersGet.Execute(us);
                return Ok(ug);
            }

            catch (EntityNotFoundException e) { return NotFound(e.Message); }
            catch (Exception e) { return StatusCode(500, e.Message); }
        }

        // GET: api/Users/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            try
            {
                return Ok(_userGet.Execute(id));

            }
            catch (EntityNotFoundException e) { return NotFound(e.Message); }
            catch (Exception e) { return StatusCode(500, e.Message); }
        }

        // POST: api/Users
        [HttpPost]
        public ActionResult Post([FromBody] CreateUserDto dto)
        {

            try { _userCreate.Execute(dto);return StatusCode(204); }
            catch (EntityAlreadyExistsException e) { return UnprocessableEntity(e.Message); }
            catch (Exception e) { return StatusCode(500, e.Message); }
        }

        // PUT: api/Users/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] CreateUserDto dto)
        {
            dto.Id = id;
            try
            {
                _userEdit.Execute(dto);
                return StatusCode(204);
            }
            catch (EntityAlreadyExistsException e) { return UnprocessableEntity(e.Message); }
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

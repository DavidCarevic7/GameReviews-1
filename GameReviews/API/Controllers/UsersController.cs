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
        public readonly IGetUsersPaginatedCommand _usersGet;
        public readonly IDeleteUserCommand _deleteUser;

        public UsersController(ICreateUserCommand userCreate, IEditUserCommand userEdit, IGetUserCommand userGet, IGetUsersPaginatedCommand usersGet, IDeleteUserCommand deleteUser)
        {
            _userCreate = userCreate;
            _userEdit = userEdit;
            _userGet = userGet;
            _usersGet = usersGet;
            _deleteUser = deleteUser;
        }




        // GET: api/Users
        [HttpGet]
        public ActionResult<IEnumerable<GetUserDto>> Get([FromQuery] UserSearch us)
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
        public ActionResult<GetUserDto> Get(int id)
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

            try { _userCreate.Execute(dto);return StatusCode(201); }
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
        public ActionResult Delete(int id)
        {
            try
            {
                _deleteUser.Execute(id);
                return StatusCode(204);
            }
            catch (EntityNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}

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
    public class RolesController : ControllerBase
    {
        private readonly IAddRoleCommand _addRole;
        private readonly IGetRolesCommand _getRoles;
        private readonly IGetRoleComand _getRole;
        private readonly IEditRoleCommand _editRole;
        private readonly IDeleteRoleCommand _deleteRole;

        public RolesController(IAddRoleCommand addRole, IGetRolesCommand getRoles, IGetRoleComand getRole, IEditRoleCommand editRole, IDeleteRoleCommand deleteRole)
        {
            _addRole = addRole;
            _getRoles = getRoles;
            _getRole = getRole;
            _editRole = editRole;
            _deleteRole = deleteRole;
        }









        // GET: api/Roles
        [HttpGet]
        public ActionResult Get([FromQuery] RoleSearch rs)
        {
            try
            {
                var getRolles = _getRoles.Execute(rs);
                return Ok(getRolles);
            }
            catch (EntityNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception)
            {
                return StatusCode(500, "An error occured.Please try again later.");
            }
        }

        // GET: api/Roles/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            try {
                var role = _getRole.Execute(id);
                return Ok(role);
            }
            catch (EntityNotFoundException e) { return NotFound(e.Message); }
            catch (Exception) { return StatusCode(500, "An error occured.Please try again later."); }
        }

        // POST: api/Roles
        [HttpPost]
        public ActionResult Post([FromBody] CreateRoleDto dto)
        {
            try
            {
                _addRole.Execute(dto);
                return StatusCode(201);
            }
            catch (EntityAlreadyExistsException e)
            {
                return UnprocessableEntity(e.Message);
            }
            catch (Exception e) {
                return StatusCode(500, e.Message);
            }
            
        }

        // PUT: api/Roles/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] CreateRoleDto dto)
        {
            dto.Id = id;
            try
            {
                _editRole.Execute(dto);
                return StatusCode(204);
            }
            catch (EntityAlreadyExistsException e)
            {
                return UnprocessableEntity(e.Message);
            }
            catch (EntityNotFoundException e) {
                return NotFound(e.Message);
            }

            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {

                _deleteRole.Execute(id);
                return StatusCode(200);

            }

            catch (EntityNotFoundException e)
            {
                return NotFound(e.Message);
            }
            catch (Exception e) {
                return StatusCode(500, e.Message);
            }
        }
    }
}

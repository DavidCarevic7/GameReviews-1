using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Commands;
using Application.DTO;
using Application.Exceptions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {

        private readonly ICreateCommentCommand _createComment;

        public CommentsController(ICreateCommentCommand createComment)
        {
            _createComment = createComment;
        }

        // GET: api/Comments
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Comments/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Comments
        [HttpPost]
        public ActionResult Post([FromBody] CreateCommentDto dto)
        {
            try {
                _createComment.Execute(dto);
                return StatusCode(201);
            }
            catch(EntityNotFoundException e) { return NotFound(e.Message); }
            
            catch (Exception e){return StatusCode(500, e.Message); }
        }

        // PUT: api/Comments/5
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

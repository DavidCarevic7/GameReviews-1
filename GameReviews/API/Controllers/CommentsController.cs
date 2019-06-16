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
    public class CommentsController : ControllerBase
    {

        private readonly ICreateCommentCommand _createComment;
        private readonly IGetCommentsCommand _getAll;
        private readonly IGetCommentCommand _getOne;
        private readonly IEditCommentCommand _editComment;
        private readonly IDeleteCommentCommand _deleteComment;

        public CommentsController(ICreateCommentCommand createComment, IGetCommentsCommand getAll, IGetCommentCommand getOne, IEditCommentCommand editComment, IDeleteCommentCommand deleteComment)
        {
            _createComment = createComment;
            _getAll = getAll;
            _getOne = getOne;
            _editComment = editComment;
            _deleteComment = deleteComment;
        }





        // GET: api/Comments
        [HttpGet]
        public ActionResult Get([FromQuery] CommentSearch cs)
        {
            try
            {
                var comments = _getAll.Execute(cs);
                return Ok(comments);
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

        // GET: api/Comments/5
        [HttpGet("{id}")]
        public ActionResult Get(int id)
        {
            try
            {
                var comment = _getOne.Execute(id);
                return Ok(comment);
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
        public ActionResult Put(int id, [FromBody] EditCommentDto dto)
        {
            dto.Id = id;
            try
            {
                _editComment.Execute(dto);
                return StatusCode(204);
            }
            catch (EntityNotFoundException e) { return NotFound(e.Message); }

            catch (Exception e) { return StatusCode(500, e.Message); }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                _deleteComment.Execute(id);
                return StatusCode(204);
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
    }
}

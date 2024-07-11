using AutoMapper;
using Bloger.Core.Entities;
using Bloger.Core.Spec;
using Bloger.Core;
using Bloger.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Bloger.Controllers
{
    public class CommentsController : ApiBaseController
    {
        private readonly IGenericRepository<Comment> _dbContext;
        private readonly Mapper _mapper;

        public CommentsController(IGenericRepository<Comment> dbContext, Mapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        //Get All Comments 

        [HttpGet]
        public async Task<ActionResult<IEnumerable<CommentDTO>>> GetAllComments()
        {
            var spec = new CommentsWithDataSpec();
            var result = await _dbContext.GetAllWithSpecAsync(spec);

            var comments = _mapper.Map<IEnumerable<Comment>, IEnumerable<CommentDTO>>(result);
            return Ok(comments);
        }


        //Get By Id

        [HttpGet("id")]
        public async Task<ActionResult<CommentDTO>> GetCommentById()
        {
            var spec = new CommentsWithDataSpec();
            var result = await _dbContext.GetByIdWithSpecAsync(spec);

            var comments = _mapper.Map<Comment, CommentDTO>(result);

            return Ok(comments);
        }
    }
}

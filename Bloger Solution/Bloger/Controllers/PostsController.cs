using AutoMapper;
using Bloger.Core;
using Bloger.Core.Entities;
using Bloger.Core.Spec;
using Bloger.DTO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Bloger.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PostsController : ControllerBase
    {
        private readonly IGenericRepository<Post> _postRepository;
        private readonly IMapper _mapper;

        public PostsController(IGenericRepository<Post> postRepository, IMapper mapper)
        {
            _postRepository = postRepository;
            _mapper = mapper;
        }

        // Get all posts
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostDTO>>> GetPosts()
        {
            var spec = new PostsWithDataSpec();
            var posts = await _postRepository.GetAllWithSpecAsync(spec);

            var postsDto = _mapper.Map<IEnumerable<Post>, IEnumerable<PostDTO>>(posts);

            return Ok(postsDto);
        }

        //Get Post By Id

        [HttpGet("id")]
        public async Task<ActionResult<PostDTO>> GetPostById(int id)
        {
            var spec = new PostsWithDataSpec(id);
            var post = await _postRepository.GetByIdWithSpecAsync(spec);
            var postsDto = _mapper.Map<Post, PostDTO>(post);

            return Ok(postsDto);
        }

        //Delete Post By Id

        [HttpDelete("id")]
        public async Task<ActionResult> DeletePost(int id)
        {
            var result = await _postRepository.DeleteAsync(id);
            return Ok(result);
        }

        //Update Post By Id
        [HttpPut("id")]
        public async Task<ActionResult<UpdatePostDto>> UpdatePostById(int id, UpdatePostDto updatePostDto)
        {
            var spec = new PostsWithDataSpec(id);
            var post = await _postRepository.GetByIdWithSpecAsync(spec);

            post.Title = updatePostDto.Title;
            post.Status = updatePostDto.Status;
            post.Content = updatePostDto.Content;
            post.FeaturedImageUrl = updatePostDto.FeaturedImageUrl;
            post.CategoryId = updatePostDto.CategoryId;

            await _postRepository.UpdateAsync(post);
            return Ok(post);
        }

    }
}

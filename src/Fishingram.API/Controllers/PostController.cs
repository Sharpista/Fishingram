using AutoMapper;
using Fishingram.API.DTO;
using Fishingram.Domain.Entities;
using Fishingram.Domain.Interfaces.Repositories;
using Fishingram.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Fishingram.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class PostController : ControllerBase
    {
        private readonly IPostRepository _postRepository;
        private readonly IPostService _postService;
        private readonly IMapper _mapper;

        public PostController(IPostRepository postRepository, IPostService postService, IMapper mapper)
        {
            _postRepository = postRepository;
            _postService = postService;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PostDTO>>> GetAllPosts()
        {
            var posts = _mapper.Map<IEnumerable<PostDTO>>(await _postService.GetAll());

            return Ok(posts);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<PostDTO>> GetPostById(long id)
        {
            var post = _mapper.Map<PostDTO>(await _postService.GetById(id));
            return Ok(post);
        }
        [HttpPost]
        public async Task<ActionResult<PostDTO>> AddPost(PostDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var post = _mapper.Map<Post>(dto);

            await _postService.Add(post);

            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<PostDTO>> UpdatePost(long id, PostDTO dto)
        {
            if (id != dto.Id) return BadRequest();
            var post = _mapper.Map<Post>(dto);
            await _postService.Put(post);

            return Ok(post);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<PostDTO>> DeletePost(long id)
        {
            var post = _mapper.Map<PostDTO>(await _postService.GetById(id));
            if (post == null) return NotFound();
            await _postService.Delete(post.Id);

            return Ok();
        }
       
    }
}

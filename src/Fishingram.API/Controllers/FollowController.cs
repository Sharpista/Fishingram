using AutoMapper;
using Fishingram.API.DTO;
using Fishingram.Domain.Entities;
using Fishingram.Domain.Interfaces.Repositories;
using Fishingram.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Fishingram.API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class FollowController : ControllerBase
    {
        private readonly IFollowRepository _followRepository;
        private readonly IFollowService _followService;
        private readonly IMapper _mapper;

        public FollowController(IFollowRepository followRepository, IFollowService followService, IMapper mapper)
        {
            _followRepository = followRepository;
            _followService = followService;
            _mapper = mapper;
        }
        [HttpPost]
        public async Task<ActionResult<FollowDTO>>FollowUser(FollowDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var follow =  _mapper.Map<Follow>(dto);
            await _followService.Add(follow);

            return Ok();
        }
    }
}

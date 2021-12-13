using AutoMapper;
using Fishingram.API.DTO;
using Fishingram.Domain.Entities;
using Fishingram.Domain.Interfaces.Repositories;
using Fishingram.Domain.Interfaces.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Fishingram.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfileController : ControllerBase
    {
        private readonly IProfileRepository _profileRepository;
        private readonly IProfileService _profileService;
        private readonly IMapper _mapper;

        public ProfileController(IProfileRepository profileRepository, IProfileService profileService, IMapper mapper)
        {
            _profileRepository = profileRepository;
            _profileService = profileService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProfileDTO>>> GetAllProfiles()
        {
            var profiles = _mapper.Map<IEnumerable<ProfileDTO>>(await _profileService.GetAll());

            return Ok(profiles);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<ProfileDTO>> GetProfileById(long id)
        {
            var profile = _mapper.Map<ProfileDTO>(await _profileService.GetById(id));
            return Ok(profile);
        }
        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult<ProfileDTO>>PostProfile(ProfileDTO dto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var profile = _mapper.Map<UserProfile>(dto);

            await _profileService.Add(profile);

            return Ok();
        }

        [HttpPut]
        [Route("{id}")]
        public async Task<ActionResult<ProfileDTO>> UpdateProfile(long id, ProfileDTO dto) 
        {
            if (id != dto.Id) return BadRequest();
            var profile = _mapper.Map<UserProfile>(dto);
            await _profileService.Put(profile);

            return Ok(profile);
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult<ProfileDTO>>DeleteProfile(long id)
        {
            var profile = _mapper.Map<ProfileDTO>(await _profileService.GetById(id));
            if (profile == null) return NotFound();
            await _profileService.Delete(profile.Id);

            return Ok();
        }
       
    }
}

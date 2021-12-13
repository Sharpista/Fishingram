using AutoMapper;
using Fishingram.API.DTO;
using Fishingram.Domain.Entities;
using Fishingram.Domain.Interfaces.Repositories;
using Fishingram.Domain.Interfaces.Services;
using Fishingram.Service.Entities.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Fishingram.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IProfileRepository _profileRepository;
        private readonly IProfileService _profileService;
        private readonly IMapper _mapper;

        public AuthController(IProfileRepository profileRepository, IProfileService profileService, IMapper mapper)
        {
            _profileRepository = profileRepository;
            _profileService = profileService;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("auth")]
        public async Task<ActionResult<dynamic>> Authenticate(LoginDTO dto)
        {
            if (dto == null) return BadRequest("Authenticate Inválido");

            var userMapper = _mapper.Map<UserProfile>(dto);

            var user = await _profileService.Auntenticate(userMapper.Email, userMapper.Password);

            if (user == null) return NotFound(new { message = "Usuário ou senha inválidos" });


            var token = TokenService.GenerateToken(user);


            return new
            {
                login = user,
                token = token
            };
       
        }
    }
}

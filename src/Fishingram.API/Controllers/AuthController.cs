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
    [Route("[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly ILoginRepository _loginRepository;
        private readonly ILoginService _loginService;
        private readonly IMapper _mapper;

        public AuthController(ILoginRepository loginRepository, ILoginService loginService, IMapper mapper)
        {
            _loginRepository = loginRepository;
            _loginService = loginService;
            _mapper = mapper;
        }

        [HttpPost]
        [Route("auth")]
        public async Task<ActionResult<dynamic>> Authenticate(LoginDTO dto)
        {
            if (dto == null) return BadRequest("Login Inválido");

            var loginMapper = _mapper.Map<Login>(dto);

            var login = await _loginService.Login(loginMapper.Email, loginMapper.Password);

            if (login == null) return NotFound(new { message = "Usuário ou senha inválidos" });


            var token = TokenService.GenerateToken(login);


            return new
            {
                login = login,
                token = token
            };
       
        }
    }
}

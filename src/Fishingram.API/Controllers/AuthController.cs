using AutoMapper;
using Fishingram.API.DTO;
using Fishingram.Domain.Entities;
using Fishingram.Domain.Interfaces.Repositories;
using Fishingram.Domain.Interfaces.Services;
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

        [HttpPost, Route("login")]
        public async Task<ActionResult<LoginDTO>> Login(LoginDTO dto)
        {
            if (dto == null) return BadRequest("Login Inválido");

            var login = _mapper.Map<Login>(dto);

            var obj = await _loginService.Login(login.Email, login.Password);
            if (obj != null)
            {
                var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("superSecretKey@345"));
                var signinCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);
                var tokeOptions = new JwtSecurityToken(
                    issuer: "http://localhost:5001",
                    audience: "http://localhost:5001",
                    claims: new List<Claim>(),
                    expires: DateTime.Now.AddMinutes(5),
                    signingCredentials: signinCredentials
                );
                var tokenString = new JwtSecurityTokenHandler().WriteToken(tokeOptions);
                return Ok(new { Token = tokenString });
            }
            else
            {
                return Unauthorized();
            }
        }
    }
}

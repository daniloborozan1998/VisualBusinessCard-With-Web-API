using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using VisualBusinessCards.Dtos.Users;
using VisualBusinessCards.Services.Interface;
using VisualBusinessCards.Shared.CustomException;

namespace VisualBusinessCards.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private IUserServices _usersService;
        public UserController(IUserServices usersService)
        {
            _usersService = usersService;
        }
        [HttpPost("register")]
        [AllowAnonymous] //the user that sends the request can be unauthenticated
        public IActionResult Register([FromBody] RegisterUsersDto registerUserDto)
        {
            try
            {
                _usersService.Register(registerUserDto);
                return StatusCode(StatusCodes.Status201Created, "User registered!");
            }
            catch (UserException e)
            {
                return StatusCode(StatusCodes.Status400BadRequest, e.Message);
            }
            catch (Exception e)
            {
                //log
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred!");
            }
        }
        [HttpPost("login")]
        [AllowAnonymous] //the user that sends the request can be unauthenticated
        public ActionResult<string> Login([FromBody] LoginDtos loginDto)
        {
            try
            {
                string token = _usersService.Login(loginDto);
                return Ok(token);
            }
            catch (Exception e)
            {
                //log
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred!");
            }
        }
    }
}

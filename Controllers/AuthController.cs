﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CreateJsonWebToken.Models;
namespace CreateJsonWebToken.Controllers;
[Route("api/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    public static User user = new User();
    [HttpPost("register")]
    public ActionResult<User> Register(UserDto request)
    {
        string passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);
        user.Username = request.Username;
        user.PasswordHash = passwordHash;
        return Ok();
    }
}

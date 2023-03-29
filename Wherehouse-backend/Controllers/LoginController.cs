﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wherehouse_backend.Models;
using Wherehouse_backend.Repository;

namespace Wherehouse_backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly WherehousedbContext _context;

        public LoginController(WherehousedbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Login(string name, string password)
        {
            // Check if the user's name and password are valid
            var tulajdonos = _context.Tulajdonos.FirstOrDefault(t => t.Nev == name && t.password == password);

            if (tulajdonos == null)
            {
                return BadRequest("Invalid name or password");
            }

            // If the user's name and password are valid, set a session variable
            return Ok(new { Message = "Login successful" });
        }
    }
}

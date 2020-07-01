using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Helpers;
using Application.Commands;
using Application.DTO;
using Application.Exceptions;
using Application.Help;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
       
        private readonly JwtManager manager;

        public AuthController(JwtManager manager)
        {
            this.manager = manager;
        }


        
        // POST: api/Auth
        [HttpPost]
        public ActionResult Post([FromBody]LoginDto login)
        {
            return Ok(
                new
                {
                    token = manager.MakeToken(login.Email, login.Password)
                }
                ); ;
        }
            
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InnoTech.LegosForLife.WebApi.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace InnoTech.LegosForLife.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        [HttpPost]
        public ActionResult<string> Login([FromBody] LoginDto dto)
        {   
            //Peters kode herunder
            if (dto.Username == "Obel" && dto.Password == "Password" )
            {
                return Ok("token123");
            }
            
            return Unauthorized();
        }
    }
}
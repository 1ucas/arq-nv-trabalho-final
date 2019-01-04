using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.AspNetCore.Mvc;

namespace Identity.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        [HttpGet]
        public User Get(string token)
        {
            byte[] textAsBytes = Convert.FromBase64String(token);
            var decodedToken = Encoding.UTF8.GetString(textAsBytes);
            var userId = int.Parse(decodedToken.Split(";")[0]);
            return new UserRepository().Usuarios.First(u=> u.Id == userId);
        }
    }
}

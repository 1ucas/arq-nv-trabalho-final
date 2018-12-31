using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Identity.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        public class LoginResponse : HttpResponseMessage
        {
            public string Token { get; set; }
            public LoginResponse(System.Net.HttpStatusCode status) : base(status) { }
        }

        // POST: api/Login
        [HttpPost]
        public LoginResponse Post([FromBody] User usuario)
        {
            var usuarioEncontrado = new UserRepository().Usuarios.FirstOrDefault(u => u.Username == usuario.Username && u.Password == usuario.Password);
            if (usuarioEncontrado != null)
            {
                var response = new LoginResponse(System.Net.HttpStatusCode.OK);
                response.Token = Convert.ToBase64String(Encoding.UTF8.GetBytes($"{usuarioEncontrado.Id};{usuarioEncontrado.Username};{usuarioEncontrado.Password}"));
                return response;
            } else
            {
                return new LoginResponse(System.Net.HttpStatusCode.Unauthorized);
            }
        }
    }
}

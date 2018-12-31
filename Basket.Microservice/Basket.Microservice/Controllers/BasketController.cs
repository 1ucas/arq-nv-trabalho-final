using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Basket.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private BasketRepository reposository;

        public BasketController()
        {
            reposository = new BasketRepository();
        }

        [HttpGet]
        public Basket Get([FromQuery] int userId)
        {
            return BasketRepository.Carrinhos.FirstOrDefault(c=> c.UserId == userId);
        }
        
        [HttpDelete("expirados")]
        public void DeletaExpirados()
        {
            BasketRepository.Carrinhos.RemoveAll(c => c.Expired);
        }
    }
}

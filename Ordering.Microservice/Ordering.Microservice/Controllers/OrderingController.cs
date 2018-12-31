using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ordering.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderingController : ControllerBase
    {
        [HttpGet]
        public Order Get(int id)
        {
            return OrderRepository.Ordens.First(o => o.Id == id);
        }
        
    
        [HttpPost]
        public void Post([FromBody] OrderRequest order)
        {
            new OrderRepository().Create(order.userId, order.bookId, order.value);
        }

        public class OrderRequest
        {
            public int userId { get; set; }
            public int bookId { get; set; }
            public double value { get; set; }
        }
    }
}

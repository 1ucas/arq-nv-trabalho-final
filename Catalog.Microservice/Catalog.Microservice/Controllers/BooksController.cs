using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Catalog.Microservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        [HttpGet("{id}")]
        public Book Get(int id)
        {
            return new BookRepository().Livros.FirstOrDefault(l => l.Id == id);
        }

        [HttpGet()]
        public List<Book> Get([FromQuery] string autor)
        {
            return new BookRepository().Livros.Where(l => l.Autor == autor).ToList();
        }
    }
}

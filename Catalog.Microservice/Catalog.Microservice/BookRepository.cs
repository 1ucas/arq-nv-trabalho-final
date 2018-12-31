using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Microservice
{
    public class BookRepository
    {
        public List<Book> Livros { get; set; }

        public BookRepository()
        {
            Livros = new List<Book>();
            Livros.Add(new Book(1, "Titulo1", "Autor1", "Editora1"));
            Livros.Add(new Book(2, "Titulo2", "Autor2", "Editora2"));
            Livros.Add(new Book(3, "Titulo3", "Autor3", "Editora3"));
            Livros.Add(new Book(4, "Titulo4", "Autor3", "Editora4"));
        }
    }
}

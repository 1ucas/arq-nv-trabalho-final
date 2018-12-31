using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Microservice
{
    public class Book
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Editora { get; set; }

        public Book(int id, string titulo, string autor, string editora)
        {
            Id = id;
            Titulo = titulo;
            Autor = autor;
            Editora = editora;
        }
    }
}

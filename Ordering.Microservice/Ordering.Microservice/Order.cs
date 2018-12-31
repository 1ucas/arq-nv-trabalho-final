using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering.Microservice
{
    public class Order
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public double Valor { get; set; }
        public DateTime DataProcessada { get; set; }

        public Order(int id, int bookId, int userId, double valor, DateTime dataProcessada)
        {
            Id = id;
            BookId = bookId;
            UserId = userId;
            Valor = valor;
            DataProcessada = dataProcessada;
        }
    }
}

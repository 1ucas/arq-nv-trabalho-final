using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.Microservice
{
    public class Basket
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }
        public bool Expired { get; set; }

        public Basket(int id, int bookId, int userId, bool expired)
        {
            Id = id;
            BookId = bookId;
            UserId = userId;
            Expired = expired;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ordering.Microservice
{
    public class OrderRepository
    {
        public static List<Order> Ordens { get; set; }

        public OrderRepository()
        {
            Ordens = new List<Order>();
            Ordens.Add(new Order(1, 1, 1, 50.5, DateTime.Now));
            Ordens.Add(new Order(2, 1, 2, 30.0, DateTime.Now));
            Ordens.Add(new Order(3, 2, 1, 10.0, DateTime.Now));
            Ordens.Add(new Order(4, 2, 3, 20.5, DateTime.Now));
            Ordens.Add(new Order(5, 3, 2, 120.0, DateTime.Now));
            Ordens.Add(new Order(6, 3, 4, 15.5, DateTime.Now));
            Ordens.Add(new Order(7, 4, 4, 25.0, DateTime.Now));
        }

        public void Create(int userId, int bookId, double value)
        {
            Ordens.Add(new Order(Ordens.Count + 1, userId, bookId, value, DateTime.Now));
        }
    }
}

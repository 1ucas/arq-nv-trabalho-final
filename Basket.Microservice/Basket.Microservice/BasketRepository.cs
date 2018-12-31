using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Basket.Microservice
{
    public class BasketRepository
    {
        public static List<Basket> Carrinhos { get; set; }

        public BasketRepository()
        {
            if (Carrinhos == null)
            {
                Carrinhos = new List<Basket>();
                Carrinhos.Add(new Basket(3, 3, 1, false));
                Carrinhos.Add(new Basket(4, 8, 2, false));
                Carrinhos.Add(new Basket(6, 1, 3, true));
                Carrinhos.Add(new Basket(7, 1, 4, false));
            }
        }
    }
}

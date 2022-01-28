using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class Order
    {
        public Order(Cart card)
        {
            Date = DateTime.Now;
            OrderId = Guid.NewGuid();
            ClientCard = card;
        }

        public Guid OrderId { get; set; }
        public DateTime Date { get; set; }

        public Cart ClientCard { get; set; }
    }
}

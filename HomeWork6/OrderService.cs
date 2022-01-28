using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class OrderService
    {
        internal (string, Order) CreateOrder(Cart card)
        {
            string res = " ";
            string productNotAvailable = " ";
            int outOfStock = 0;
            CheckAvailabilityService checkAvailability = new CheckAvailabilityService();
            for (int i = 0; i < card.ClientProducts.Length; i++)
            {
                if (!checkAvailability.CheckAvailability(card.ClientProducts[i]))
                {
                    outOfStock++;
                    productNotAvailable += $"{card.ClientProducts[i].Name} not available! ";
                    card.ClientProducts[i] = null;
                }
            }

            Order clientsOrder = new Order(card);
            if (outOfStock > 0)
            {
                res = " Sorry! Order not complete. " + productNotAvailable;
            }
            else
            {
                res = $"Success! Your order {clientsOrder.OrderId} has been generated.";
            }

            return (res, clientsOrder);
        }
    }
}

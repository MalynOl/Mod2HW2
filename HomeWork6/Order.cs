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
        public Order()
        {
            Date = DateTime.Now;
            OrderId = Guid.NewGuid();
            ClientProducts = Product.GetMasClientsProducts();
        }

        public Guid OrderId { get; set; }
        public DateTime Date { get; set; }
        public Product[] ClientProducts { get; set; }
        public string ProcessedOrder(Basket basket)
        {
            // ClientProducts = basket.ClientProducts;
            string res = " ";
            string productNotAvailable = " ";
            int outOfStock = 0;
            for (int i = 0; i < ClientProducts.Length; i++)
            {
                if (!ClientProducts[i].IsAvailable)
                {
                    outOfStock++;
                    productNotAvailable += $"{ClientProducts[i].Name} not available! ";
                }
            }

            if (outOfStock > 0)
            {
                res = " Sorry! " + productNotAvailable;
            }
            else
            {
                res = $"Success! Your order {OrderId} has been generated.";
            }

            return res;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class CartService
    {
        internal static Cart FullCart(Product[] clientsProduct)
        {
            Cart clientsCard = new Cart(clientsProduct);
            return clientsCard;
        }
    }
}

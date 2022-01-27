using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class ServiceFullCard
    {
        internal static Card FullClientsCard(Product[] clientsProduct)
        {
            Card clientsCard = new Card(clientsProduct);
            return clientsCard;
        }
    }
}

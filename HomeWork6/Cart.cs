using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class Cart
    {
        private Guid _idCard;
        private Guid _idClient;

        public Cart(Product[] clientsProduct)
        {
            ClientProducts = clientsProduct;
            _idCard = Guid.NewGuid();
            _idClient = Guid.NewGuid();
        }

        public Product[] ClientProducts { get; set; }
    }
}

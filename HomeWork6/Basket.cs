using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class Basket
    {
        private Guid _idBasket;
        private Guid _idClient;
        public Basket()
        {
            ClientProducts = Product.GetMasClientsProducts();
            _idBasket = Guid.NewGuid();
            _idClient = Guid.NewGuid();
        }

        public Product[] ClientProducts { get; set; }
        internal Basket FullBasket(Product[] allProduct)
        {
            Random random = new Random();
            int randomValue = 0;
            for (int i = 0; i < ClientProducts.Length; i++)
            {
                randomValue = random.Next(0, allProduct.Length);
                ClientProducts[i] = allProduct[randomValue];
            }

            return this;
        }
    }
}

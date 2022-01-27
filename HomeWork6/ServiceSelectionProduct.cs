using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class ServiceSelectionProduct
    {
        public ServiceSelectionProduct(int countProduct)
        {
            CountClientsProduct = countProduct;
        }

        public int CountClientsProduct { get; set; }
        internal Product[] SelectClientsProduct(Product[] allProduct)
        {
            Product[] clientProducts = new Product[CountClientsProduct];
            Random random = new Random();
            int randomValue = 0;
            for (int i = 0; i < clientProducts.Length; i++)
            {
                randomValue = random.Next(0, allProduct.Length);
                while (clientProducts.Contains(allProduct[randomValue]))
                {
                    randomValue = random.Next(0, allProduct.Length);
                }

                clientProducts[i] = allProduct[randomValue];
            }

            return clientProducts;
        }
    }
}

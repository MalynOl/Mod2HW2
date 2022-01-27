using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class ServiseWriteAvailableProduct
    {
        internal void WriteAvailableProduct(Product[] products)
        {
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i] != null)
                {
                    Console.WriteLine($"{products[i].Name} is available");
                }
            }
        }
    }
}

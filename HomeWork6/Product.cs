using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class Product
    {
        private static readonly Product[] MasClientsProducts = new Product[5];
        static Product()
        {
        }

        public Product()
        {
        }

        public string Name { get; set; }
        public int Id { get; set; }
        public bool IsAvailable { get; set; }
        public static Product[] GetMasClientsProducts()
        {
            return MasClientsProducts;
        }
    }
}
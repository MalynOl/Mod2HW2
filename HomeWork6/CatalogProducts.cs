using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class CatalogProducts
    {
        public CatalogProducts()
        {
            AllProducts = new Product[]
            {
                new Product() { Id = 1, Name = "Cookie", IsAvailable = true },
                new Product() { Id = 2, Name = "Biscuit", IsAvailable = false },
                new Product() { Id = 3, Name = "Fruit jellies", IsAvailable = true },
                new Product() { Id = 4, Name = "Marshmallow", IsAvailable = true },
                new Product() { Id = 5, Name = "Candy", IsAvailable = true },
                new Product() { Id = 6, Name = "Jam", IsAvailable = false },
                new Product() { Id = 7, Name = "Juice", IsAvailable = true },
                new Product() { Id = 8, Name = "Honey", IsAvailable = false },
                new Product() { Id = 9, Name = "Lollipop", IsAvailable = true },
                new Product() { Id = 10, Name = "Bagel", IsAvailable = true },
                new Product() { Id = 11, Name = "Cake", IsAvailable = true },
                new Product() { Id = 12, Name = "Chocolate", IsAvailable = true },
                new Product() { Id = 13, Name = "Cupcake", IsAvailable = false },
                new Product() { Id = 14, Name = "Donut", IsAvailable = true },
                new Product() { Id = 15, Name = "Tart", IsAvailable = true },
            };
        }

        public Product[] AllProducts { get; set; }
    }
}

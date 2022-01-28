using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork6
{
    internal class Starter
    {
        private CatalogProducts _catalog;
        private OrderService _clientOrder;
        private SelectProductService _selectionProduct;
        private WriteService _serviseWrite;

        public Starter()
        {
            _catalog = new CatalogProducts();
            _clientOrder = new OrderService();
            _selectionProduct = new SelectProductService(CountClientsProduct);
            _serviseWrite = new WriteService();
        }

        public int CountClientsProduct => 5;

        public void Start()
        {
            Product[] clientProduct = _selectionProduct.SelectClientsProduct(_catalog.AllProducts);
            Cart clientsCard = CartService.FullCart(clientProduct);
            var (stringOrder, order) = _clientOrder.CreateOrder(clientsCard);
            _serviseWrite.WriteString(stringOrder);
            _serviseWrite.WriteAvailableProduct(order.ClientCard.ClientProducts);
        }
    }
}

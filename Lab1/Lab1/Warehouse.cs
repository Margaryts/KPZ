using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Warehouse
    {
        private List<Product> products = new List<Product>();

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void ShowInventory()
        {
            foreach (var product in products)
            {
                product.Display();
            }
        }
    }
}

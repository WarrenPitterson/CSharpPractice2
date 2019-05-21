using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ACM.BL
{
    class ProductRepository
    {
        public Product Retrieve(int productId)
        {
            Product product = new Product(productId);

            if (productId == 2)
            {
                product.ProductName = "Sunflowers";
                product.ProductDescription = "The most yellow of yellowish sunflowers";
                product.CurrentPrice = 9.99M;
            }
        Object myObject = new object();
        Console.WriteLine($"Object: {myObject.ToString()}");
        Console.WriteLine($"Product: {product.ToString()}");
        return product;
        }

        public bool Save(Product product)
        {
          return true;
        }
    }
}

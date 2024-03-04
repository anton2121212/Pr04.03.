using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr04._03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();

          
            products.Add(new SinProduct
            {
                Name = "Milk",
                Price = 2.5m,
                ProductionDate = new DateTime(2024, 1, 1),
                ExpiryDate = new DateTime(2024, 3, 1)
            });

            products.Add(new Batch
            {
                Name = "Cookies",
                Price = 3.0m,
                Quantity = 100,
                ProductionDate = new DateTime(2023, 12, 1),
                ExpiryDate = new DateTime(2024, 6, 1)
            });

            List<Product> expiredProducts = FindExpiredProducts(products);

            Console.WriteLine("All products:");
            foreach (var product in products)
            {
                product.Info();
            }

            Console.WriteLine("Expired products:");
            foreach (var product in expiredProducts)
            {
                product.Info();
            }
        }

        static List<Product> FindExpiredProducts(List<Product> products)
        {
            List<Product> expiredProducts = new List<Product>();
            foreach (var product in products)
            {
                if (product.IsExpired())
                {
                    expiredProducts.Add(product);
                }
            }
            return expiredProducts;
        }
    }
}

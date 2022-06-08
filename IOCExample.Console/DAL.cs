using System;
using System.Collections.Generic;
using System.Text;

namespace IOCExample
{
    public class DAL : IDAL
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Product 1",
                    Price = 10.00m,
                    Stock = 100
                },
                new Product()
                {
                    Id = 2,
                    Name = "Product 2",
                    Price = 20.00m,
                    Stock = 200
                },
                new Product()
                {
                    Id = 3,
                    Name = "Product 3",
                    Price = 30.00m,
                    Stock = 300
                },
                new Product()
                {
                    Id = 4,
                    Name = "Product 4",
                    Price = 40.00m,
                    Stock = 400
                }
            };
        }

    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace IOCExample
{
    public class OtherDAL : IDAL
    {
        public List<Product> GetProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Id = 1,
                    Name = "Ürün 1",
                    Price = 10.00m,
                    Stock = 100
                },
                new Product()
                {
                    Id = 2,
                    Name = "Ürün 2",
                    Price = 20.00m,
                    Stock = 200
                },
                new Product()
                {
                    Id = 3,
                    Name = "Ürün 3",
                    Price = 30.00m,
                    Stock = 300
                },
                new Product()
                {
                    Id = 4,
                    Name = "Ürün 4",
                    Price = 40.00m,
                    Stock = 400
                }
            };
        }
    }
}

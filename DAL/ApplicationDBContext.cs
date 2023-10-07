using DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ApplicationDBContext
    {
        static List<Product> products = new List<Product> {
         new() { Id = Guid.NewGuid(), Name = "Şekar Pancarı", Price = 100, Quantity = 10, CreateTime = DateTime.Now },
         new() { Id = Guid.NewGuid(), Name = "Ayçekirdeği", Price = 200, Quantity = 20, CreateTime = DateTime.Now },
         new() { Id = Guid.NewGuid(), Name = "Yonca", Price = 300, Quantity = 30, CreateTime = DateTime.Now },
         new() { Id = Guid.NewGuid(), Name = "Buğday", Price = 400, Quantity = 40, CreateTime = DateTime.Now },
         new() { Id = Guid.NewGuid(), Name = "Arpa", Price = 500, Quantity = 50, CreateTime = DateTime.Now },
         new() { Id = Guid.NewGuid(), Name = "Yulaf", Price = 600, Quantity = 60, CreateTime = DateTime.Now }
        };

        public static List<Product> Products => products;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionPrograms
{
    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
           return $"Id: {Id}, Name: {Name}, Price: ${Price:F2}";
        }


        //static void Main(string[] args)
        //{
        //    List<Product> products = new List<Product>();

        //    //Adding products
        //    products.Add(new Product { Id = 1, Name = "Laptop", Price = 35000.00 }); 
        //    products.Add(new Product { Id = 2, Name = "Keyboard", Price = 1200.00 });
        //    products.Add(new Product { Id = 3, Name = "Pendrive", Price = 500.00 });
        //    products.Add(new Product { Id = 4, Name = "Mouse", Price = 799.00 });
        //    Console.WriteLine("Product List" +products);
        //    DisplayProducts(products);

        // }
        //static void DisplayProducts(List<Product> products)
        //{
        //    if (products.Count == 0)
        //    {
        //        Console.WriteLine("No product available");
        //    }
        //    else
        //    {
        //        Console.WriteLine(String.Join(Environment.NewLine, products));
        //    }
        //}
    }
}

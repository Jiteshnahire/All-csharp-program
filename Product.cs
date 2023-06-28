using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public  double Price { get; set; }

        public override string ToString()
        {
            return $"Id={Id} Name={Name} Price={Price}";
        }
    }
    public class ProductDemo
    {
        static void Main(string[] args)
        {
            Product p = new Product { Id = 1, Name = "Dell", Price = 5000 };
            Console.WriteLine(p.ToString());
             
         }
    }
}

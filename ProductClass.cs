using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
     class ProductClass
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public void Discount(double discountPercentage)
        {
            double discountAmount = Price * (discountPercentage / 100);
            double discountPrice = Price - discountAmount;

            Console.WriteLine($"Actual Price: {Price}");
            Console.WriteLine($"Discount Price: {discountPrice}");
        }
        public override string ToString()
        {
            return $"Id={Id} Name={Name} Price={Price}";
        }
        class ProductClassDemo
        {
            static void Main(string[] args)
            {
                ProductClass demo = new ProductClass { Id = 1, Name = "Dell", Price = 3000 };
                Console.WriteLine(demo.ToString());

                double discountPercentage = 10;
                demo.Discount(discountPercentage);
            }
        }
    }
}

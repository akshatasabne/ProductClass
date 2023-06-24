using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // property initializer
            Product product = new Product();
            product.ProductCode = 45;
            product.Productname = "Italian";
            product.ProductPrice = 500;

            Console.WriteLine($"Product Details is {product.ProductCode}:{product.Productname}:{product.ProductPrice}");
            //// object initializer
            Product product1 = new Product() { ProductCode=45,Productname="Italian",ProductPrice=500};

            Console.WriteLine($"Product Details is{product1.ProductCode},{product1.Productname},{product1.ProductPrice}");

        }
    }
}

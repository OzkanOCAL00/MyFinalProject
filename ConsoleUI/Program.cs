using Business.Concrete;
using DataAccess.Concreat.EntityFramework;
using DataAccess.Concreat.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var Product in productManager.GetByUnitPrice(40,100))
            {
                Console.WriteLine(Product.ProductName);
            }

            
        }
    }
}

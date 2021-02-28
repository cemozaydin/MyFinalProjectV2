using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductTest();

            //CategoryTest();


        }

        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

            foreach (var category in categoryManager.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            Console.WriteLine("----------------------GetAll()----------------------------");
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("----------------------GetByUnitPrice-----------------------");
            foreach (var product in productManager.GetByUnitPrice(50, 100))
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("--------------------GetAllByCategoryId---------------------");
            foreach (var product in productManager.GetAllByCategoryId(2))
            {
                Console.WriteLine(product.ProductName);
            }

            Console.WriteLine("--------------------GetProductDetailDto---------------------");
            foreach (var productDetail in productManager.GetProductDetails())
            {
                Console.WriteLine(productDetail.ProductId + " / " + productDetail.ProductName + " / " + productDetail.CategoryName );
            }

        }
    }
}

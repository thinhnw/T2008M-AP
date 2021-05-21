using System;
using System.Reflection;
using ConsoleApplication1.lab3;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ExecLab3();
        }

        public static void ExecLab1()
        {
            Product product = new Product();
            product.Id = 1;
            product.Name = "Play Station 5";
            for (var i = 0; i < Product.GALLERY_LENGTH_MAX + 1; ++i)
            {
                product.AddToGallery("product image");
            }
            product.GetInfo();
            
        }

        public static void ExecLab3()
        {
            Product juiceBox = new Product();
            juiceBox.Name = "Orange juice";
            juiceBox.Price = 12000;

            Product snack = new Product();
            snack.Name = "Snack Lays";
            snack.Price = 19000;

            Cart cart = new Cart();
            
            cart.AddProduct(juiceBox); 
            cart.AddProduct(snack);

            cart.city = "Ha Noi";
            Console.WriteLine(cart.CalcGrandTotalWithFee());
        }
    }
}
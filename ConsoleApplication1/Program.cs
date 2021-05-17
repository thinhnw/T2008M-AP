using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
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
    }
}
using System;
using System.CodeDom;
using System.Runtime.ConstrainedExecution;

namespace ConsoleApplication1
{
    public class Product
    {
        public const int GALLERY_LENGTH_MAX = 10;
        // id, name, price, qty, image, desc, gallery < string array>;
        private int Id { get; set; }
        private string Name { get; set; }
        private string Price { get; set; }
        private int Qty { get; set; }
        private string Image { get; set; }
        private string Desc { get; set; }
        private string[] Gallery { get; }

        public Product()
        {
            Gallery = new String[10];
        }

        public Product(int id, string name, string price, int qty, string image, string desc, string[] gallery)
        {
            Id = id;
            Name = name;
            Price = price;
            Qty = qty;
            Image = image;
            Desc = desc;
            Gallery = gallery;
        }

        public void GetInfo()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Quantity: " + Qty);
            Console.WriteLine("Image: " + Image);
            Console.WriteLine("Desc: " + Desc);
            Console.WriteLine("Gallery: " + Gallery);
        }

        public Boolean isOutOfStock()
        {
            return Qty > 0;
        }

        public void AddToGallery(string image)
        {
            if (Gallery.Length == 10)
            {
                Console.WriteLine("Number of Images (10) reached. Please remove some to add another.");
                return;
            }

            for (int i = 0; i < 10; ++i)
            {
                if (string.Equals(Gallery[i], ""))
                {
                    Gallery[i] = image;
                    Console.WriteLine("Image successfully added.");
                    return;
                }
            }
        }
        
    }
}
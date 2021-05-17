using System;
using System.CodeDom;
using System.Runtime.ConstrainedExecution;

namespace ConsoleApplication1
{
    public class Product
    {
        public const int GALLERY_LENGTH_MAX = 10;
        // id, name, price, qty, image, desc, gallery < string array>;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Price { get; set; }
        public int Qty { get; set; }
        public string Image { get; set; }
        public string Desc { get; set; }
        public string[] Gallery { get; set; }

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
            PrintGallery();
        }

        public Boolean isOutOfStock()
        {
            return Qty > 0;
        }

        public void AddToGallery(string image)
        {
            if (!string.IsNullOrEmpty(Gallery[GALLERY_LENGTH_MAX - 1]))
            {
                Console.WriteLine("Number of Images (10) reached. Please remove some to add another.");
                return;
            }

            for (int i = 0; i < GALLERY_LENGTH_MAX; ++i)
            {
                if (string.IsNullOrEmpty(Gallery[i]))
                {
                    Gallery[i] = image;
                    Console.WriteLine("Image successfully added.");
                    return;
                }
            }
        }

        public void PrintGallery()
        {
            Console.WriteLine("Gallery:");
            for (var i = 0; i < GALLERY_LENGTH_MAX; ++i)
            {
                Console.Write("\"" + Gallery[i] + "\""); 
                Console.Write(", ");
            }
        }

        public void RemoveFromGalleryPrompt()
        {
            PrintGallery();
            Console.WriteLine("Specify which one you want to remove:");
            Console.Write("index = ");
            try
            {
                int index = Convert.ToInt32(Console.ReadLine());
                RemoveFromGallery(index);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        private void RemoveFromGallery(int index)
        {
            Gallery[index] = "";
            Console.WriteLine("Success!");
            PrintGallery();
        }
        
    }
}
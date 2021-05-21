using System;

namespace ConsoleApplication1.lab2
{
    public class Fashion : Product
    {
       public string Color { get; set; } 
       public string Size { get; set; }

       public Fashion()
       {
           
       }

       public Fashion(string color, string size)
       {
           Color = color;
           Size = size;
       }

       public Boolean hasSize(string size)
       {
           return (Size.Equals(size) && Qty > 0);
       }
    }
}
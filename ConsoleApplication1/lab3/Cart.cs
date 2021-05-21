using System.Collections.Generic;

namespace ConsoleApplication1.lab3
{
    public class Cart
    {
        public int id;
        public string customerName;
        public double grandTotal;
        public List<Product> productList;
        public string city;
        public string country;

        public Cart()
        {
            productList = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            productList.Add(product);
            grandTotal += product.Price;
        }

        public void RemoveProduct(Product product)
        {
            if (productList.Remove(product))
            {
                grandTotal -= product.Price;
            }
        }

        public double CalcGrandTotalWithFee()
        {
            if (city.Equals("Ha Noi") || city.Equals("HCM")) return grandTotal * 101 / 100;
            if (country.Equals("Vietnam")) return grandTotal * 102 / 100;
            return grandTotal * 105 / 100;
        }
        
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Shopping_Spree
{
    internal class Product
    {
        string name;
        int price;
        public Product(string name, int price)
        {
            this.name = name;
            this.price = price;
        }
        public string Name
        {
            get { return name; }
        }
        public int Price
        {
            get { return price; }
        }
    }
}

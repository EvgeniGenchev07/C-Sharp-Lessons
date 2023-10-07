using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.На_пазар
{
    internal class Product
    {
        string name;
        int price;
        public Product(string name, int price)
        {
            this.Name = name;
            this.price = price;
        }
        public string Name
        {
            get { return name; }
            set 
            {
                if (value.Length == 0) throw new ArgumentException("Name cannot be empty");
                name = value; 
            }

        }
        public int Price
        {
            get { return price; }
        }
    }
}

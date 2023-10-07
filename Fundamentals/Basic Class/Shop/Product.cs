using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class Product
    {
        private string name;
        private string qrCode;
        private double price;
        private double amount;
        public Product(string qrCode, string name, double price, double amount)
        {
            this.name = name;
            this.qrCode = qrCode;
            this.price = price;
            this.amount = amount;
        }
        public string QrCode { get { return this.qrCode; } }
        public string Name
        {
            get { return this.name; }
            private set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("Product must have name");
                name = value;
            }
        }
        public double Price { get { return this.price; } }
        public double Amount { get { return amount; } set { this.amount = value; } }
    }
}

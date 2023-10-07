using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_
{
    internal class Food
    {
        public string Barcode { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public Brand Brand { get; set; }
        public override string ToString()
        {
            return $"Barcode: {Barcode}\nName: {Name}\nPrice: {Price}\nQuantity: {Quantity}\nBrand Name: {Brand.Name}";
        }
    }
}

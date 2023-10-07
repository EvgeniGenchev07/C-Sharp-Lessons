using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal static class Command
    {
        private static List<Product> products = new List<Product>();
        public static void AddProduct(string productId,string productName,double productPrice,double productAmount)
        {
            products.ForEach(p => { if (p.QrCode == productId) throw new ArgumentException("The product already exist"); });
            products.Add(new Product(productId, productName, productPrice, productAmount));
        }
        public static void UpdateProduct(string productCode, double productAmount)
        {
            bool value = false;
            products.ForEach(p => { if (p.QrCode == productCode) { p.Amount = productAmount; value = true; } });
            if (!value) Console.WriteLine("Please add your product first!");
        }
        public static void SellProduct(string productCode, double productAmount)
        {
            products.ForEach(p => { if (p.QrCode == productCode) 
                {
                    if(productAmount > p.Amount) Console.WriteLine("Not enough quantity");
                    else p.Amount -= productAmount;
                } });
        }
        public static void Calculate()
        {
            Console.WriteLine($"{products.Sum(p=>p.Price*p.Amount):f2}");
        }
        public static void PrintA()
        {
            List<Product> sortedProducts = products.Where(p=>p.Amount!=0).ToList();
            sortedProducts = sortedProducts.OrderBy(p => p.Name).ToList();
            sortedProducts.ForEach(p => { Console.WriteLine($"{p.Name} ({p.QrCode})"); });
        }
        public static void PrintU()
        {
            List<Product> sortedProducts = products.Where(p => p.Amount == 0).ToList();
            sortedProducts = sortedProducts.OrderBy(p => p.Name).ToList();
            sortedProducts.ForEach(p => { Console.WriteLine($"{p.Name} ({p.QrCode})"); });
        }
        public static void PrintD()
        {
            List<Product> sortedProducts = products.Where(p => p.Amount != 0).ToList();
            sortedProducts=sortedProducts.OrderByDescending(p => p.Amount).ToList();
            sortedProducts.ForEach(p => { Console.WriteLine($"{p.Name} ({p.QrCode})"); });
        }
    }
}

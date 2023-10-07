using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            while (input[0] != "Close")
            {
                string cmd = input[0];
                if (cmd == "Calculate") Command.Calculate();
                else if (cmd == "PrintA") Command.PrintA();
                else if (cmd == "PrintD") Command.PrintD();
                else if (cmd == "PrintU") Command.PrintU();
                else if (cmd == "Add")
                {
                    string productCode = input[1];
                    string productName = input[2];
                    double productPrice = double.Parse(input[3]);
                    double productAmount = double.Parse(input[4]);
                    Command.AddProduct(productCode, productName, productPrice, productAmount);
                }
                else
                {
                    string productCode = input[1];
                    double productAmount = double.Parse(input[2]);
                    switch (cmd)
                    {
                        case "Update":
                            Command.UpdateProduct(productCode, productAmount);
                            break;
                        case "Sell":
                            Command.SellProduct(productCode, productAmount);
                            break;
                    }
                }
                input = Console.ReadLine().Split(' ');
            }
            
        }
    }
}
    

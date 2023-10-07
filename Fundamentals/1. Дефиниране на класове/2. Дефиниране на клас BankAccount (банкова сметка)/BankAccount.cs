using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _2.Дефиниране_на_клас_BankAccount__банкова_сметка_
{
    internal class BankAccount
    {
        public int Id { get; set; }
        public double Balance { get; set; }
        public void Information()
        {
            Console.WriteLine($"Account: {Id}, balance: {Balance:f2}");
        }
    }
}

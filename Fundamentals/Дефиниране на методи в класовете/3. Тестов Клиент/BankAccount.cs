using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Дефиниране_на_клас_BankAccount
{
    internal class BankAccount
    {
        int id;
        double balance;
        public BankAccount(int id)
        {
            this.id = id;
        }
        public double Balance
        {
            get { return balance; }
        }
        public void Deposit(double amount)
        {
            balance += amount;
        }
        public void WithDraw(double amount)
        {
            balance-= amount;
        }
        public void Print()
        {
            Console.WriteLine($"Account ID{id}, balance {balance:f2}");
        }
    }
}

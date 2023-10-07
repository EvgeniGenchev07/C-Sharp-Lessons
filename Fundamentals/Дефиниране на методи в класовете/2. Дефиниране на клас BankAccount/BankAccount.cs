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
        public BankAccount(int id, double balance)
        {
            this.id = id;
            this.balance = balance;
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
            Console.WriteLine($"id: {id} balance: {balance}");
        }
    }
}

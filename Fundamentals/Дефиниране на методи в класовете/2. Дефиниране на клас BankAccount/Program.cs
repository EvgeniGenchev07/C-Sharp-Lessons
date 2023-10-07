using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Дефиниране_на_клас_BankAccount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int id = int.Parse(Console.ReadLine());
            double balance = double.Parse(Console.ReadLine());
            BankAccount bankAccount = new BankAccount(id, balance);
            string[] action = Console.ReadLine().Split(' ');
            while (action[0] != "end")
            {
                if (action[0] == "deposit")bankAccount.Deposit(double.Parse(action[1]));
                else bankAccount.WithDraw(double.Parse(action[1]));
                action = Console.ReadLine().Split(' ');
            }
            bankAccount.Print();
        }
    }
}

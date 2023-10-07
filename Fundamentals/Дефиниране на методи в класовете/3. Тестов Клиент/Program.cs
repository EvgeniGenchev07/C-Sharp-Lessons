using _2.Дефиниране_на_клас_BankAccount;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace _3.Тестов_Клиент
{
    internal class Program
    {
        static Dictionary<int,BankAccount> bankAccounts;
        static void Main(string[] args)
        {
            bankAccounts = new Dictionary<int, BankAccount>();
            string[] command = Console.ReadLine().Split(' ');
            while (command[0] != "End")
            {
                switch (command[0])
                {
                    case "Create":
                        Create(int.Parse(command[1]));
                        break;
                    case "Print":
                        Print(int.Parse(command[1]));
                        break;
                    case "Deposit":
                        Deposit(int.Parse(command[1]), double.Parse(command[2]));
                        break;
                    case "Withdraw":
                        Withdraw(int.Parse(command[1]), double.Parse(command[2]));
                        break;
                }
                command = Console.ReadLine().Split(' ');
            }

        }
        static void Create(int id)
        {
            if (bankAccounts.ContainsKey(id)) Console.WriteLine("Account already exists");
            else bankAccounts.Add(id, new BankAccount(id));
        }
        static void Deposit(int id, double balance)
        {
            if (!bankAccounts.ContainsKey(id)) Console.WriteLine("Account does not exist");
            else bankAccounts[id].Deposit(balance);
        }
        static void Withdraw(int id, double balance)
        {
            if (!bankAccounts.ContainsKey(id)) Console.WriteLine("Account does not exist");
            else
            {
                if (bankAccounts[id].Balance<balance) Console.WriteLine("Insufficient balance");
                else bankAccounts[id].WithDraw(balance);
            }
        }
        static void Print(int id)
        {
            if (!bankAccounts.ContainsKey(id)) Console.WriteLine("Account does not exist");
            else bankAccounts[id].Print();
        }

    }
}

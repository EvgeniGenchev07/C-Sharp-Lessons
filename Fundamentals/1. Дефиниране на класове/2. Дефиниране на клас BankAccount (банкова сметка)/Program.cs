using _1.Дефиниране_на_клас_Person;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Дефиниране_на_клас_BankAccount__банкова_сметка_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();
            BankAccount bankAccount = new BankAccount();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                persons.Add(new Person(Console.ReadLine(), int.Parse(Console.ReadLine())));
                bankAccount.Id = int.Parse(Console.ReadLine());
                bankAccount.Balance = double.Parse(Console.ReadLine());
                persons[i].IntroduceYourself();
                bankAccount.Information();
            }
        }
    }
}

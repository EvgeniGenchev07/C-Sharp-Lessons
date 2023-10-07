using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Човекът_и_неговите_пари
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<BankAccounts> bankAccounts = new List<BankAccounts>();
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            string[] account = Console.ReadLine().Split();
            while (account[0] != "end")
            {
                bankAccounts.Add(new BankAccounts(int.Parse(account[0]), double.Parse(account[1])));
                account = Console.ReadLine().Split();
            }
            Person pers = new Person(name,age,bankAccounts);
            pers.GetBalance();
        }
    }
}

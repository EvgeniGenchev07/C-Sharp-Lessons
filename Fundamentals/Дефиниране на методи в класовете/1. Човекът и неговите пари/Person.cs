using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _1.Човекът_и_неговите_пари
{
    internal class Person
    {
        string name;
        int age;
        List<BankAccounts> bankAccounts;

        public Person(string name,int age) : this(name,age,new List<BankAccounts>())
        {

        }
        public Person(string name, int age,List<BankAccounts> bankAccounts)
        {
            this.name = name;
            this.age = age;
            this.bankAccounts = bankAccounts;
        }
        public void GetBalance()
        {
            Console.WriteLine(bankAccounts.Sum(bankAccount=>bankAccount.Balance)); 
        }
    }
}

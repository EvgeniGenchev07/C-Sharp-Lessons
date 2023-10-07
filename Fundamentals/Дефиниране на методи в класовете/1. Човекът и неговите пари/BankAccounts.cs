using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Човекът_и_неговите_пари
{
    internal class BankAccounts
    {
        int id;
        double balance;
        public BankAccounts(int id, double balance)
        {
            this.id = id;
            this.balance = balance;
        }
        public double Balance
        {
            get { return balance; }
        }
    }
}

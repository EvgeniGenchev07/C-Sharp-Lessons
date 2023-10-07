using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Military_Elite
{
    internal class Private : Soldier
    {
        private decimal salary;
        public Private(string id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName)
        {
            this.salary = salary;
        }
        public override string ToString()
        {
            return base.ToString() + $" Salary: {salary}";
        }
    }
}

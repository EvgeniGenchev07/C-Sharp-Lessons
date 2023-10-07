using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Military_Elite
{
    internal class Spy : Soldier
    {
        private string codeNumber;
        public Spy(string id, string firstName, string lastName, string codeNumber) : base(id, firstName, lastName)
        {
            this.codeNumber = codeNumber;
        }
        public override string ToString()
        {
            return base.ToString() + $"\nCode Number: {codeNumber}";
        }
    }
}

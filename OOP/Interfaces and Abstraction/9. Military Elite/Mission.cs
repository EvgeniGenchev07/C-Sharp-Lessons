using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Military_Elite
{
    internal class Mission
    {
        string codeName;
        string status;
        public Mission(string codeName, string status)
        {
            this.codeName = codeName;
            this.status = status;
        }
        public override string ToString()
        {
            return $"Code Name: {codeName} State: {status}";
        }
    }
}

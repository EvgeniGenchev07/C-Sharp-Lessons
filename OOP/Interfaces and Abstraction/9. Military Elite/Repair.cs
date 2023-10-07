using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Military_Elite
{
    internal class Repair
    {
        private string partName;
        private int hours;
        public Repair(string partName, int hours)
        {
            this.partName = partName;
            this.hours = hours;
        }
        public override string ToString()
        {
            return $"Part Name: {partName} Hours Worked: {hours}";
        }
    }
}

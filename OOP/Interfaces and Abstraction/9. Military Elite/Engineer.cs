using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _9.Military_Elite
{
    internal class Engineer : SpecialisedSoldier
    {
        List<Repair> repairs = new List<Repair>();
        private string corps;
        public Engineer(string id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary, corps)
        {
        }
        public void AddRepairs(string[] repairs)
        {
            for (int i = 0; i < repairs.Length; i += 2)
            {
                this.repairs.Add(new Repair(repairs[i], int.Parse(repairs[i + 1])));
            }
        }
        public override string ToString()
        {
            return base.ToString() + $"Repairs:\n    {string.Join("\n    ", repairs.Select(x => x.ToString()))}";
        }
    }
}

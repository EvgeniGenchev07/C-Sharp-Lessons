using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Military_Elite
{
    internal class LieutenantGeneral : Soldier
    {
        private decimal salary;
        private List<Private> privates = new List<Private>();
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary) : base(id, firstName, lastName)
        {
            this.salary = salary;
        }
        public decimal Salary { get { return salary; } }
        public List<Private> Privates { get { return privates; } }
        public void PrivateCommanding(List<Soldier> people, List<string> ids)
        {
            people.Reverse();
            people.ForEach(person =>
            {

                for (int i = ids.Count - 1; i >= 0; i--)
                {
                    if (person.Id == ids[i] && ids.Count != 0)
                    {
                        privates.Add(person as Private);
                        ids.Remove(ids[i]);
                        break;
                    }
                }

            });
        }
        public override string ToString()
        {
            return base.ToString() + $" Salary: {salary:f2}\nPrivates:\n    " + string.Join("\n    ", privates.Select(x => x.ToString()));
        }
    }
}

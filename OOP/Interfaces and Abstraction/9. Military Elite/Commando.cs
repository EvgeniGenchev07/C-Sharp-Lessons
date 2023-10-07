using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Military_Elite
{
    internal class Commando : SpecialisedSoldier
    {
        private List<Mission> missions = new List<Mission>();
        private string corps;
        public Commando(string id, string firstName, string lastName, decimal salary, string corps) : base(id, firstName, lastName, salary, corps)
        {
        }
        public void AddMission(string[] missions)
        {
            for (int i = 0; i < missions.Length; i += 2)
            {
                if (missions[i + 1] == "inProgress" || missions[i + 1] == "Finished")
                {
                    this.missions.Add(new Mission(missions[i], missions[i + 1]));
                }
            }
        }
        public override string ToString()
        {
            if (missions.Count == 0) return base.ToString() + $"Misions:";
            return base.ToString() +
                $"Misions:\n    {string.Join("\n    ", missions.Select(x => x.ToString()))}";
        }
    }
}

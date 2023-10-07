using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Първи_и_резервен_Отбор
{
    internal class Team
    {
        string name;
        List<Person> firstTeam;
        List<Person> reservTeam;
        public Team(string name)
        {
             this.name = name;
             firstTeam= new List<Person>();
             reservTeam = new List<Person>();
        }
        public IReadOnlyCollection<Person> FirstTeam
        {
            get { return firstTeam; }
        }
        public IReadOnlyCollection<Person> ReservTeam { get { return reservTeam; } }
        public void AddPlayer(string[] info)
        {
            string name = info[0] + " " + info[1];
            if (int.Parse(info[2]) < 40)
            {
                firstTeam.Add(new Person(name, int.Parse(info[2]), double.Parse(info[3])));
            }
            else
            {
                reservTeam.Add(new Person(name, int.Parse(info[2]), double.Parse(info[3])));
            }
        }
        public void CountPrint()
        {
            Console.WriteLine($"First team have {FirstTeam.Count()} players");
            Console.WriteLine($"Reserve team have {ReservTeam.Count()} players");
        }
    }
}

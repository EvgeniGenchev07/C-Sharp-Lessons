using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace _3.Създаване_на_футболен_отбор
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            string[] cmd = Console.ReadLine().Split(';');
            while (cmd[0] != "END")
            {
                switch (cmd[0])
                {
                    case "Team":
                        teams.Add(new Team(cmd[1]));
                        break;
                    case "Add":
                        bool add = true;
                        teams.ForEach(team => { if (team.Name == cmd[1]) { team.AddPlayer(cmd); add = false; } });
                        if(add) PrintInvalidTeam(cmd[1]);
                        break;
                    case "Remove":
                        bool remove = true;
                        teams.ForEach(team => { if (team.Name == cmd[1])team.RemovePlayer(cmd[2]); });
                        break;
                    case "Rating":
                        bool find = true;
                        teams.ForEach(team => { if (team.Name == cmd[1]) { Console.WriteLine($"{team.Name} - {team.Rate}"); find = false; } });
                        if(find) PrintInvalidTeam(cmd[1]);
                        break;
                }
                cmd = Console.ReadLine().Split(';');
            }
        }
        static void PrintInvalidTeam(string name)
        {
            Console.WriteLine($"Team {name} does not exist.");
        }
    }
}

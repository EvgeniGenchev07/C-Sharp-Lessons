using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _5.Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            bool isCorrect = false;
            string[] input = new string[2];
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split('-');
                isCorrect = false;
                for (int j = 0; j < teams.Count; j++)
                {
                    if (teams[j].Owner == input[0])
                    {
                        Console.WriteLine($"{input[0]} cannot create another team!");
                        isCorrect = true;
                        break;
                    }
                    if (teams[j].TeamName == input[1])
                    {
                        isCorrect = true;
                        Console.WriteLine($"Team {input[1]} was already created!");
                        break;  
                    }
                }
                if (!isCorrect)
                {
                    teams.Add(new Team(input[0], input[1]));
                    Console.WriteLine($"Team {input[1]} has been created by {input[0]}!");
                }
            }
            input = Console.ReadLine().Split('-');
            while (input[0] != "end of assignment")
            {
                input[1]=input[1].Remove(0,1);
                isCorrect = false;
                for (int i = 0; i < teams.Count; i++)
                {
                    if (teams[i].Owner == input[0])
                    {
                        Console.WriteLine($"Member {input[0]} cannot join team {input[1]}!");
                        isCorrect = true;
                        break;
                    }
                }
                if (!isCorrect)
                {
                    for (int i = 0; i < teams.Count; i++)
                    {
                        if (teams[i].TeamName == input[1])
                        {
                            teams[i].Members.Add(input[0]);
                            break;
                        }
                        if (teams[i].TeamName != input[1] && i==teams.Count-1)
                        {
                            Console.WriteLine($"Team {input[1]} does not exist!");
                        }
                    }
                }
                input = Console.ReadLine().Split('-');
            }
            List<string> disbandTeams = new List<string>();
            foreach (var team in teams.OrderByDescending(team => team.Members.Count))
            {
                if (team.Members.Count!=0)
                {
                    team.Print();
                }
                else disbandTeams.Add(team.TeamName);
            }
            Console.WriteLine("Teams to disband:");
            disbandTeams.ForEach(t => Console.WriteLine(t));
        }
    }
}

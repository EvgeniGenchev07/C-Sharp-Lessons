using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _3.Създаване_на_футболен_отбор
{
    internal class Team
    {
        string name;
        double rate;
        List<Player> players;
        public Team(string name) 
        {
            this.name = name;
            players = new List<Player>();
        }
        public string Name { get { return name; } }
        public double Rate { get { return rate; } }
        public void AddPlayer(string[] info)
        {
            if (info[2] == "") Console.WriteLine("A name should not be empty.");
            else if (byte.Parse(info[3]) > 100 || byte.Parse(info[3]) < 0) PrintInvalidStat("Endurance");
            else if (byte.Parse(info[4]) > 100 || byte.Parse(info[4]) < 0) PrintInvalidStat("Sprint");
            else if (byte.Parse(info[5]) > 100 || byte.Parse(info[5]) < 0) PrintInvalidStat("Drible");
            else if (byte.Parse(info[6]) > 100 || byte.Parse(info[6]) < 0) PrintInvalidStat("Passes");
            else if (byte.Parse(info[7]) > 100 || byte.Parse(info[7]) < 0) PrintInvalidStat("Aim");
            else
            {
                players.Add(new Player(info[2], byte.Parse(info[3]), byte.Parse(info[4]), byte.Parse(info[5]), byte.Parse(info[6]), byte.Parse(info[7])));
                rate = players.Sum(player => player.Rate);
            }
        }
        
        public void RemovePlayer(string name)
        {
            bool find = true;
            for (int i = 0; i < players.Count(); i++)
            {
                if (players[i].Name == name) { players.RemoveAt(i); find = false; }
            }
            if (find) Console.WriteLine($"Player {name} is not in {this.name} team.");
            else rate = players.Sum(player => player.Rate);
        }
        
        static void PrintInvalidStat(string stat)
        {
            Console.WriteLine($"{stat} should be between 0 and 100.");
        }
    }
}

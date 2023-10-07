using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Teamwork_Projects
{
    internal class Team
    {
        string owner;
        string teamName;
        List<string> members;
        public Team(string owner,string teamName)
        {
            this.owner = owner;
            this.teamName = teamName;
            members = new List<string>();
        }
        public List<string> Members
        {
            get { return members; }
            set { members = value; }
        }
       

        public string Owner
        {
            get { return owner; }
            set { owner = value; }
        }
        public string TeamName
        {
            get { return teamName; }
            set { teamName = value; }
        }
        public void Print()
        {
            Console.WriteLine(teamName);
            Console.WriteLine($"- {owner}");
            foreach (string member in members)
            {
                Console.WriteLine($"-- {member}");
            }
            
        }

    }
}

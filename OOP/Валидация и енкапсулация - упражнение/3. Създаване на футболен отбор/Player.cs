using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Създаване_на_футболен_отбор
{
    internal class Player
    {
        string name;
        byte endurance;
        byte sprint;
        byte drible;
        byte passes;
        byte aim;
        double rate;
        public Player(string name, byte endurance, byte sprint, byte drible, byte passes, byte aim)
        {
            this.name = name;
            this.endurance = endurance;
            this.sprint = sprint;
            this.drible = drible;
            this.passes = passes;
            this.aim = aim;
            double sum = (double)(endurance + sprint + drible + passes + aim) / 5;
            rate = Math.Round(sum);
        }
        public void Delete()
        {

        }
        public string Name
        {
            get { return name; }
        }
        public double Rate
        {
            get { return rate; }
        }
    }
}

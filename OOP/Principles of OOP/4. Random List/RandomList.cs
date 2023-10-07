using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Random_List
{
    internal class RandomList : List<string>
    {
        public string RandomString()
        {
            Random random = new Random();
            int index = random.Next(0, base.Count);
            string el = base[index];
            base.RemoveAt(index);
            return el;
        }
    }
}

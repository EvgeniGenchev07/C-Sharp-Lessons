using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Birthday_Celebrations
{
    internal class Pet : IBirthable
    {
        private string name;
        private string birthdate;
        public Pet(string name, string date)
        {
            this.name = name;
            Birthdate = date;
        }
        public string Birthdate { get { return birthdate; } set { birthdate = value; } }
        public string DateSearching()
        {
            return Birthdate;
        }
    }
}

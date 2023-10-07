
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Birthday_Celebrations
{
    internal class Citizen : IBirthable
    {
        private string name;
        private int age;
        private string id;
        private string birthdate;
        public Citizen(string name,int age, string id,string date)
        {
            this.name = name;
            this.age = age;
            this.id = id;
            Birthdate = date;
        }
        public string Birthdate { get { return birthdate; } set { birthdate = value; } }
        public string DateSearching()
        {
            return Birthdate;
        }
    }
}

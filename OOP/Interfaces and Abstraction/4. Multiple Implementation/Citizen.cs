using _4.Multiple_Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Multiple_Implementation
{
    internal class Citizen : IPerson, IIdentifiable, IBirthable

    {
        private string name;
        private int age;
        private string id;
        private string birthday;
        public Citizen(string name, int age, string id, string birthday)
        {
            Name = name;
            Age = age;
            Birthdate = birthday;
            Id = id;
        }
        public string Name { get { return name; } set { name = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string Id { get { return id; } set { id = value; } }
        public string Birthdate { get { return birthday; } set { birthday = value; } }
    }
}

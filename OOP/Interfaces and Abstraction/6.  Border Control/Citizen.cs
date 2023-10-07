
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Border_Control
{
    internal class Citizen : IIdentifiable
    {
        private string name;
        private int age;
        private string id;
        public Citizen(string name,int age, string id)
        {
            this.name = name;
            this.age = age;
            Id = id;
        }
        public string Id { get { return id; } set { id = value; } }
        public void IdSearching(string el)
        {
            string value = Id.Substring(Id.Length - el.Length, el.Length);
            if (value == el)
            {
                Console.WriteLine(Id);
            }
        }
    }
}

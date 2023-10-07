using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9.Military_Elite
{
    internal class Soldier : ISoldier
    {
        private string firstName;
        private string lastName;
        private string id;
        protected Soldier(string id, string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
        }
        protected string FirstName { get { return firstName; } set { firstName = value; } }
        protected string LastName { get { return lastName; } set { lastName = value; } }
        public string Id { get { return id; } set { id = value; } }
        public override string ToString()
        {
            return $"Name: {firstName} {lastName} Id: {id}";
        }
    }
}

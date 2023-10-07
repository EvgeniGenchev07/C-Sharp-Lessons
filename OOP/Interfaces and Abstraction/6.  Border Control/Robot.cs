
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Border_Control
{
    internal class Robot : IIdentifiable
    {
        private string model;
        private string id;
        public Robot(string model, string id)
        {
            this.model = model;
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Поправка_на_email_и
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<string,string> emails = new SortedDictionary<string,string>();
            string name = Console.ReadLine();
            while (name != "stop")
            {
                string email = Console.ReadLine();
                string endIndexs = email.Remove(0,email.Length - 2);
                if (endIndexs != "us" && endIndexs != "uk")
                {
                    emails.Add(name, email);
                }
                name = Console.ReadLine();
            }
            foreach (var item in emails)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}

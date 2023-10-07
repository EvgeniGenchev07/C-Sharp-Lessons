using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "ConsoleWord";
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.Black;
            StreamWriter writer = new StreamWriter("C:\\Users\\user\\Downloads\\text.txt",false,Encoding.UTF8);
            string answer = null;
            while (answer!="No")
            {
                while (true)
                {
                    string line = Console.ReadLine();
                    if (line == "Stop")
                    {
                        break;
                    }
                    writer.WriteLine(line);
                }
                Console.WriteLine("Do you want to save the file?");
                answer = Console.ReadLine();
                if (answer != "Yes")
                {
                    
                    File.Delete("C:\\Users\\user\\Downloads\\text.txt");
                    
                }
                writer.Close();
                Console.WriteLine("Do you want to write something else");
                answer = Console.ReadLine();
            }
        }
    }
}

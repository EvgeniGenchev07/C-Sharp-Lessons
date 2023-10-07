using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stream
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Encoding utf8 = Encoding.GetEncoding("UTF-8");
            StreamWriter writer = new StreamWriter("C:\\Users\\user\\Downloads\\test.txt",false, utf8);
            using (writer)
            {
                for (int i = 1; i <= 20; i++)
                {
                    writer.WriteLine(i);
                }
            }
            StreamReader reader = new StreamReader("C:\\Users\\user\\Downloads\\test.txt", utf8);
            using (reader)
            {
                Console.WriteLine(reader.ReadToEnd());
                File.WriteAllText("C:\\Users\\user\\Downloads\\testooo.txt", "1235");
            }
            string a = File.ReadAllText("C:\\Users\\user\\Downloads\\testooo.txt");
            Console.WriteLine(a);
        }
    }
}

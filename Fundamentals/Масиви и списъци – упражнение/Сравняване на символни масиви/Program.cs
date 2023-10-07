using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Сравняване_на_символни_масиви
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] a = Console.ReadLine().Split(' ').ToArray();
            string[] b = Console.ReadLine().Split(' ').ToArray();
            string c = null;
            string d = null;
            for (int i = 0; i < a.Length; i++)
            {
                c += a[i];
            }
            for (int i = 0; i < b.Length; i++)
            {
                d += b[i];
            }
            for (int i = 0; i < a.Length; i++)
            {

            }
        }
    }
}

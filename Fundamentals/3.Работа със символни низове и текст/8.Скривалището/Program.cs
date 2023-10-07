using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _8.Скривалището
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] treasure = Console.ReadLine().Split(' ').ToArray();
            int count = 0;
            int maxCount = 0;
            int index = 0;
            int maxCountIndex = 0;
            int times = 0;
            while (true)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    if (text[i].ToString() == treasure[0] && times == 0)
                    {
                        count++;
                        index = i;
                        times++;
                    }
                    else if (text[i].ToString() == treasure[0] && times != 0) count++;
                    else
                    {
                            if (maxCount < count)
                            {
                                maxCount = count; 
                                count = 0;  
                            }
                            else count = 0;
                            times = 0;
                    }
                }
                if (maxCount >= int.Parse(treasure[1])) break; 
                else treasure = Console.ReadLine().Split(' ').ToArray();  
            }
            Console.WriteLine($"Hideout found at index {index} and it is with size {maxCount}!");
            
        }
    }
}

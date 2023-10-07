using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Списъчен_манипулатор
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> nums=Console.ReadLine().Split (' ').Select(int.Parse).ToList();

            List<string> comand = Console.ReadLine().Split(' ').ToList();
            while (comand[0]!="print")
            {
                if (comand[0] =="add")
                {
                    int a = int.Parse(comand[2]);
                    int b = int.Parse(comand[1]);
                    nums.Insert(b,a);
                }
                else if (comand[0]=="addMany")
                {
                    int a = int.Parse(comand[1]);
                    comand.RemoveRange(0, 2);
                    int[] b=new int[comand.Count];
                    for (int i = 0; i < comand.Count; i++)
                    {
                        b[i] = int.Parse(comand[i]);
                    }
                    nums.InsertRange(a,b);
                }
                else if (comand[0]=="contains")
                {
                    bool k=nums.Contains(int.Parse(comand[1]));
                    if (k)
                    {
                        for (int i = 0; i < nums.Count; i++)
                        {
                            if (nums[i] == int.Parse(comand[1]))
                            {
                                Console.WriteLine(i);
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(-1);
                    }
                }
                else if (comand[0]=="remove")
                {
                    nums.RemoveAt(int.Parse(comand[1]));
                }
                else if (comand[0] == "shift")
                {
                    for (int i = 0; i < int.Parse(comand[1]); i++)
                    {
                        int a = nums[i];
                        nums.RemoveAt(i);
                        nums.Add(a);
                    }
                }
                else if (comand[0] == "sumPairs")
                {
                    int a = nums.Count;
                    int j = 0;
                    if (a%2!=0)
                    {
                        a--;
                    }
                    for (int i = 1 ; i < a; i+=2,j+=2)
                    {
                        int sum = nums[i]+ nums[j];
                        nums.Add(sum);
                        sum = 0;
                        
                    }
                    nums.RemoveRange(0, a);
                }
                comand=Console.ReadLine().Split(' ').ToList();

            }
            Console.Write("[");
            Console.Write(string.Join(", ", nums));
            Console.Write("]");
        }
    }
}

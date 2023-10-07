using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    internal class Rectangle : IDrawable
    {
        private int weight;
        private int height;
        public Rectangle(int weight, int height)
        {
            this.weight = weight;
            this.height = height;
        }
        public void Draw()
        {
            Console.WriteLine(new string('*',weight));
            for (int i = 0; i < height-3; i++)
            {
                Console.WriteLine('*'+new string(' ',weight-2)+'*');
                Console.WriteLine();
            }
            Console.WriteLine('*' + new string(' ', weight - 2) + '*');
            Console.WriteLine(new string('*', weight));
        }
    }
}

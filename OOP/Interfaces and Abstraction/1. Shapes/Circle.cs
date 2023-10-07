using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Shapes
{
    internal class Circle : IDrawable
    {
        private int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public void Draw()
        {
            double rIn = radius - 0.4;
            double rOut = radius + 0.4;
            for (double r = radius; r >= -radius; r--)
            {
                for (double x = -radius; x < rOut; x += 0.5)
                {
                    double value = x * x + r*r;
                    if (value >= rIn * rIn && value <= rOut * rOut)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}

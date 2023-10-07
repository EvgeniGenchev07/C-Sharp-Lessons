using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _4.Клас_Box__правоъгълен_паралелепипед_
{
    internal class Box
    {
        double length;
        double width;
        double height;
        public Box(double length, double width, double height)
        {
            this.length = length;
            this.width = width;
            this.height = height;
        }
        public void GetSurfaceArea()
        {
            double surfaceArea = 2 * (length * width + length * height + width * height);
            Console.WriteLine($"Surface Area – {surfaceArea:f2}");
        }
        public void GetLateralSurfaceArea()
        {
            double lateralSurfaceArea = 2 * (length * height + width * height);
            Console.WriteLine($"Lateral Surface Area – {lateralSurfaceArea:f2}");
        }
        public void GetVolume()
        {
            double volume= length*width*height;
            Console.WriteLine($"Volume – {volume:f2}");
        }
    }
}

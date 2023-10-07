using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Валидация_на_данните_на_класа_Box
{
    internal class Box
    {
        double length;
        double width;
        double height;
        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;
        }
        public double Length
        {
            set 
            {
                if (value < 0) throw new ArgumentException("Length cannot be zero or negative.");
                this.length = value; 
            }
        }
        public double Width
        {
            set 
            {
                if (value < 0) throw new ArgumentException("Width cannot be zero or negative.");
                this.width = value; 
            }
        }
        public double Height
        {
            set 
            {
                if (value < 0) throw new ArgumentException("Height cannot be zero or negative.");
                this.height = value; 
            }
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
            double volume = length * width * height;
            Console.WriteLine($"Volume – {volume:f2}");
        }
    }
}

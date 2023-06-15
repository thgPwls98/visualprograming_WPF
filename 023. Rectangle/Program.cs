using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023.Rectangle
{
    class Rectangle
    {
        private double width, height;

        public Rectangle(double w, double h)
        {
            this.width = w;
            this.height = h;
        }

        public double GetArea()
        {
            return width * height;
        }

        public double GetPerimeter()
        {
            return (width + height) * 2;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle(5,3);
            double area=rect.GetArea();
            double perimeter=rect.GetPerimeter();

            Console.WriteLine("넓이: " + area);
            Console.WriteLine("둘레: " + perimeter);
        }
    }
}

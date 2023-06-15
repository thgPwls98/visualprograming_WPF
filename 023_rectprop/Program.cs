using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_rectprop
{
    public class Rectangle
    {
        public double Width{ get; set; }
        public double Height { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Width = 5;
            rect.Height = 3;

            double area=rect.Width * rect.Height;
            double perimeter=(rect.Height+rect.Width)*2;

            Console.WriteLine("넓이: " + area);
            Console.WriteLine("둘레: " + perimeter);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_rectprop2
{
    public class Rectangle
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public Rectangle(double w, double h)
        {
            Width = w;
            Height = h;
        }
        public Rectangle()
        {
            Width = 0;
            Height = 0;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Rectangle();
            rect.Width = 10;
            rect.Height = 10;

            


        }
    }
}

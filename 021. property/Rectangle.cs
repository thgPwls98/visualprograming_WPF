using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021.property
{
    internal class Rectangle
    {
        public double Width{ get; set; }  // 뒤에 ; 없음
        public double Height { get; set; }
    }

    public class Rectangle2
    { //propfull + tap + tap
        private double width;

        public double Width
        {
            get { return width; }
            set { if(value>0) width = value; }  //조건을 써줄 수 있다.
        }

        private double height;

        public double Height
        {
            get { return height; }
            set { if(value>0) height = value; }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _018.ClassInCS_66
{
    internal class Program
    {
        class Product
        {
            public string name;
            public int price;
        }
        class MyMath
        {
            public static double PI = 3.14; //static : 정적 변수(클래스변수)
        }

        class MyCalendar
        {
            public const int months = 12;
            public const int weeks = 52;
            public const int days = 365;

            public const double daysPerWeek=(double)days/(double)weeks;
            public const double daysPerMonth=(double)days/(double)months;

        }
        static void Main(string[] args)
        {
            Product p = new Product();
            p.name = "시계";
            p.price = 100000;

            Console.WriteLine("{0}:{1:C}", p.name, p.price);
            Console.WriteLine("원주율: {0}", MyMath.PI);   //static은 클래스.이름 으로 쓴다. 객체를 안 만들어도 된다!!
            Console.WriteLine("한달은 평균 {0:F3}일", MyCalendar.daysPerMonth);  //const도 static처럼 쓸 수 있다.
        }
    }
}

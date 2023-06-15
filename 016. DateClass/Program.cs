﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _016.DateClass
{
    class Date
    {
        int year, month, day;
        public Date()
        {
            year = 1;
            month=1; 
            day=1;
        }
        public Date(int y, int m, int d)
        {
            year = y;
            month = m;
            day = d;
        }
        public void SetYear (int year)
        {
            this.year = year;
        }

        public int GetYear ()
        {
            return this.year;
        }

        public void PrintDate()
        {
            Console.WriteLine("{0}년 {1}월 {2}일", this.year, this.month, this.day);
        }
        
    };
    internal class Program
    {
        static void Main(string[] args)
        {
            Date a = new Date();
            Date b = new Date(2023, 6, 7);

            a.SetYear(2023);
            Console.WriteLine(a.GetYear());
            a.PrintDate();
            b.PrintDate();
        }
    }
}

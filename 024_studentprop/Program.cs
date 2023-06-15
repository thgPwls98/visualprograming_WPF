using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _024_studentprop
{
    class Student
    {
        private string name, major;
        private int age;
        public int Age { get; set; }
        public string Name{ get; set; }
        public string Major { get; set; }


        public Student(string n, int a, string m)
        {
            this.name = n;
            this.age = a;
            this.major = m;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("이름: {0}, 나이: {1}, 전공: {2}", name, age, major);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("홍길동", 20, "의료IT공학");
            s.DisplayInfo();
        }
    }
}

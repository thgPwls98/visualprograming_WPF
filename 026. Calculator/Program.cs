using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _026.Calculator
{
    class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }

        public static int Multiply(int a, int b)
        {
            return (a * b);
        }

        public static double Divide(int a, int b)
        {
            return a / b;
        }
    }

    class calculator
    {
        public int add(int a, int b)
        {
            return a + b;
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 5;

            int sum = Calculator.Add(num1, num2);
            int difference = Calculator.Subtract(num1, num2);
            int product = Calculator.Multiply(num1, num2);
            double quotient = Calculator.Divide(num1, num2);

            Console.WriteLine("덧셈: " + sum);
            Console.WriteLine("뺄셈: " + difference);
            Console.WriteLine("곱셈: " + product);
            Console.WriteLine("나눗셈: " + quotient);

            
            calculator calculator = new calculator();
            int Sum= calculator.add(num1, num2);
            Console.WriteLine("덧셈: " + Sum);


        }
    }
}

//필드의 멤버변수는 소문자, 속성의 멤버변수는 대문자
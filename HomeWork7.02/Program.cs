using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork7._02
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise 1
            /*int a=0;
            Console.WriteLine("Input number (0-100):");
            a = Convert.ToInt32(Console.ReadLine());
            while (true) { 
             if(a >= 0 & a <= 100)
                {
                    break;
                }
                else {
                    Console.WriteLine("Input number (0-100):");
                    a = Convert.ToInt32(Console.ReadLine());
                };
            };
             
            if ((a % 3)==0)
            {
                Console.WriteLine("Fizz");
            };
            if ((a % 5) == 0)
            {
                Console.WriteLine("Buzz");
            };
            if ((a % 5) != 0 & (a % 3) != 0)
            {
                Console.WriteLine(a);
            };

                Console.ReadKey();*/
            #endregion
            #region Exercise 2
            /*Console.WriteLine("Input number:");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input %:");
            double b = Convert.ToDouble(Console.ReadLine());
            double c = a / 100 * b;
            Console.WriteLine($"{b}% ot {a} = {c}");
            Console.ReadKey();*/
            #endregion
            #region Exercise 3
            /*int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());
            int abcd = a * 1000 + b * 100 + c * 10 + d;
            Console.WriteLine(abcd);
            Console.ReadKey();*/
            #endregion
            #region Exercise 4
            /*int number = int.Parse(Console.ReadLine());
            int a1 = number % 10;
            int a2 = number / 10 % 10;
            int a3 = number / 100 % 10;
            int a4 = number / 1000 % 10;
            int a5 = number / 10000 % 10;
            int a6 = number / 100000 % 10;
            Console.WriteLine($"{a1}{a2}{a3}{a4}{a5}{a6}");
            Console.ReadKey();*/
            #endregion
            #region Exercise 5
            /*Console.WriteLine("Input year:");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("Input month:");
            int month = int.Parse(Console.ReadLine());
            Console.WriteLine("Input day:");
            int day = int.Parse(Console.ReadLine());
            DateTime dt = new DateTime(year, month, day);
            if(month == 12 || month == 1 || month == 2)
            {
                Console.WriteLine("Зима");
            };
            if (month == 3 || month == 4 || month == 5)
            {
                Console.WriteLine("Весна");
            };
            if (month == 6 || month == 7 || month == 8)
            {
                Console.WriteLine("Лето");
            };
            if (month == 9 || month == 10 || month == 11)
            {
                Console.WriteLine("Осень");
            };
            Console.WriteLine(dt.ToString("dddd"));
            Console.ReadLine();
            Console.ReadKey();*/
            #endregion
            #region Exercise 6
            /*Console.WriteLine("Input temp:");
            int temp = int.Parse(Console.ReadLine());
            int a,b;
            while (true)
            {
                Console.WriteLine("1-Fariengeit 2 - Tselsia:");
                a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        b = temp * 9 / 5 + 32;
                            Console.WriteLine($"Fariengeit:{b}"); ;
                        break;
                    case 2:
                        Console.WriteLine($"Tselsia:{temp}"); ;
                        break;
                }
            }
            Console.ReadKey();*/
            #endregion
            #region Exercise 7
            int c;
            Console.WriteLine("Input numbers 1:");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Input numbers 2:");
            int b = int.Parse(Console.ReadLine());
            if (a > b) {
                Console.WriteLine("ERROR A>B");
                c = a;
                a = b;
                b = c;
            };
            for (; a <= b; a++)
            {
                Console.WriteLine(a);
            };
            Console.ReadKey();
            #endregion;
        }
    }
}

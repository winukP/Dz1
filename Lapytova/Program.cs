using System;
using System.Security.Cryptography;
using System.Threading;

namespace Lapytova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine(Math.Round(Math.E, 1));
            //2
            Console.WriteLine(50);
            Console.WriteLine(10);
            //3
            Random random = new Random();
            Console.WriteLine(random.Next(100));
            Console.WriteLine(random.Next(100));
            Console.WriteLine(random.Next(100));
            Console.WriteLine(random.Next(100));
            //4
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(number+10);
            //5
            double x = 5.6;
            double y = Math.Cos(x);
            Console.WriteLine(y);
            //6
            int osnm = 2;
            int osnb = 5;
            int h = 3;
            double bok = Math.Sqrt(Math.Pow(((osnb - osnm) / 2.0), 2)+Math.Pow(h, 2));
            double perim = bok * 2 + osnm + osnb;
            Console.WriteLine(perim);
            //7
            Console.WriteLine("Мир Труд Май");
            Console.WriteLine("Мир");
            Console.WriteLine("    Труд");
            Console.WriteLine("         Май");
            //8
            Console.Write("Введите 1 числo: ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("Введите 2 числo: ");
            int a2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"{a2} {a1}");
            //9
            int ch = int.Parse(Console.ReadLine());
            Console.Write($"Вы ввели число {ch}");
            //10
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / 2.0;
            double x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / 2.0;
            Console.WriteLine($"{x1} {x2}");
            //11
            int num1 = 9;
            int num2 = 7;
            Console.WriteLine((num1 + num2) / 2.0);
            Console.WriteLine(Math.Sqrt(num1 * num2));
            //12
            double x1 = 7.123;
            double x2 = 5.789;
            double y1 = 2.456;
            double y2 = 9.234;
            double dist = Math.Sqrt((x2 - x1)* (x2 - x1) + (y2 - y1)*(y2 - y1));
            Console.WriteLine(dist);
            //13
            //a
            int a1, b1, c1, d1;
            a1 = 1;
            b1 = 2;
            c1 = 3;
            Console.WriteLine($"{a1} {b1} {c1}");
            d1 = a1;
            a1 = b1;
            b1 = c1;
            c1 = d1;
            Console.WriteLine($"{a1} {b1} {c1}");
            //b
            a1 = 1;
            b1 = 2;
            c1 = 3;
            Console.WriteLine($"{a1} {b1} {c1}");
            d1 = c1;
            c1 = b1;
            b1 = a1;
            a1 = d1;
            Console.WriteLine($"{a1} {b1} {c1}");
            //14
            int sec = 56701;
            Console.WriteLine(sec / 3600);
            Console.WriteLine((sec / 60)%60);
            Console.WriteLine(sec%60);
            //15
            int s1 = 130 * 543;
            int s2 = 130 * 130;
            Console.WriteLine(s1/s2);
            //16
            int trex = 678;
            string trex1 = $"{(trex % 10)}{(trex / 10)}";
            Console.WriteLine(trex1);
            //17
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(n/100);
            Console.WriteLine(n / 1000);
            //18
            //a
            Console.Write("Введите ваше имя: ");
            string name=Console.ReadLine();
            Console.WriteLine(name);
            //b
            Console.Write("Введите ваше имя: ");
            name = Console.ReadLine();
            Console.WriteLine($"Hello {name}");
            //19
            Console.WriteLine("Привет, Консоль");
            Console.WriteLine("Привет, как тебя зовут?");
            string name1 = Console.ReadLine();
            Console.WriteLine($"Привет, {name1}");
            Console.WriteLine("Ты знаешь что-нибудь о тайной комнате?");
            Console.WriteLine("Да");
            Console.WriteLine("Можешь ли ты рассказать о ней?");
            Console.WriteLine("Нет");
            Thread.Sleep(5000);
            Random random = new Random();
            Console.ForegroundColor = (ConsoleColor)random.Next(1,15);
            Console.WriteLine("но могу показать");
            //20
            //a
            Random random = new Random();
            int h1, h2, h3, h4, h5, h6, h7, h8, h9, h10, h11, h12;
            h1 = random.Next(0, 10);
            h2 = random.Next(0, 10);
            h3 = random.Next(0, 10);
            h4 = random.Next(0, 10);
            h5 = random.Next(0, 10);
            h6 = random.Next(0, 10);
            h7 = random.Next(0, 10);
            h8 = random.Next(0, 10);
            h9 = random.Next(0, 10);
            h10 = random.Next(0, 10);
            h11 = random.Next(0, 10);
            h12 = random.Next(0, 10);
            int sum1 = h1 + h3 + h5 + h7 + h9 + h11+(h2 + h4 + h6 + h8 + h10 + h12) * 3;
            Console.WriteLine((10 - (sum1 % 10)) % 10);
            //b
            h1 = int.Parse(Console.ReadLine());
            h2 = int.Parse(Console.ReadLine());
            h3 = int.Parse(Console.ReadLine());
            h4 = int.Parse(Console.ReadLine());
            h5 = int.Parse(Console.ReadLine());
            h6 = int.Parse(Console.ReadLine());
            h7 = int.Parse(Console.ReadLine());
            h8 = int.Parse(Console.ReadLine());
            h9 = int.Parse(Console.ReadLine());
            h10 = int.Parse(Console.ReadLine());
            h11 = int.Parse(Console.ReadLine());
            h12 = int.Parse(Console.ReadLine());
            sum1 = h1 + h3 + h5 + h7 + h9 + h11 + (h2 + h4 + h6 + h8 + h10 + h12) * 3;
            Console.WriteLine((10 - (sum1 % 10)) % 10);
            Console.ReadKey();
        }
    }
}

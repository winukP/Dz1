using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lapytova
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
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
            */
            //10
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / 2.0;
            double x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / 2.0;
            Console.WriteLine($"{x1} {x2}");
            Console.ReadKey();
            //11
            //12
            //13


        }
    }
}

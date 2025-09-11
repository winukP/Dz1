using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tumakov
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1
            Console.WriteLine("Как тебя зовут?");
            string name=Console.ReadLine();
            Console.WriteLine($"Hi {name}!");
            //2
            double num1 =int.Parse(Console.ReadLine());
            double num2 = int.Parse(Console.ReadLine());
            if (num2 != 0)
            {
                Console.WriteLine(num1 / num2);
            }
            else
            {
                Console.WriteLine("Ошибка");
            }
            //3
            string alf = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            char buk = Console.ReadKey().KeyChar;
            Console.WriteLine();
            for (int i = 0; i <= alf.Length-1; i++)
            {
                if (buk == 'Z')
                {
                    Console.WriteLine('A');
                    break;
                }
                if (alf[i] == buk)
                {
                    Console.WriteLine(alf[i + 1]);
                }
            }
            //4
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double x1 = (-b + Math.Sqrt(b * b - 4 * a * c)) / 2.0;
            double x2 = (-b - Math.Sqrt(b * b - 4 * a * c)) / 2.0;
            Console.WriteLine($"{x1} {x2}");
            Console.ReadKey();
        }
    }
}

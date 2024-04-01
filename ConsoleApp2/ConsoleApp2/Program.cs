using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Коваль Ангелiна");
            Console.WriteLine("КН21");

            int a, b, c, a1, b1, c1;

            Console.WriteLine("Трикутник А");

            Console.WriteLine("Введiть сторону а");

            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Введiть сторону b");

            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Введiть сторону c");

            c = int.Parse(Console.ReadLine());

            double pA, SA;
            if (a + b > c && a + c > b && c + a > b)
            {
            }
            else
            {
                Console.WriteLine("Помилка, трикутника А не iснує");
            }

            pA = (a + b + c) / 2;
            SA = Math.Sqrt(pA * (pA - a) * (pA - b) * (pA - c));

            Console.WriteLine("Трикутник Б");

            Console.WriteLine("Введiть сторону а1");
                
            a1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введiть сторону b1");

            b1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введiть сторону c1");

            c1 = int.Parse(Console.ReadLine());

            double pB, SB;
            if (a1 + b1 > c1 && a1 + c1 > b1 && c1 + a1 > b1)
            {
            }
            else
            {
                Console.WriteLine("Помилка, трикутника Б не iснує");
            }

            pB=(a1 + b1 +  c1) / 2;
            SB = Math.Sqrt(pB * (pB - a) * (pB - b) * (pB - c));

            Console.WriteLine("Площа трикутника А = ");
            Console.WriteLine(SA);
            Console.WriteLine("площА трикутника Б = ");
            Console.WriteLine(SB);

            if (SA > SB)
            {
                Console.WriteLine("Площа трикутника А бiльша за площу трикутника Б");
            }
            else if (SA < SB)
            {
                Console.WriteLine("Площа трикутника Б бiльша за площу трикутника А");
            }
        }
    }
}

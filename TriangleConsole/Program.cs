using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, x1, x2, x3, y1, y2, y3, s, s1, s2, s3, p, p1, p2, p3, a, b, c, k1, k2, k3;
            Console.WriteLine("Введите координаты вершин");
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
            x3 = Convert.ToDouble(Console.ReadLine());
            y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите координаты точки");
            x = Convert.ToDouble(Console.ReadLine());
            y = Convert.ToDouble(Console.ReadLine());
            a = Math.Sqrt(Math.Pow((x1 - x2), 2) + Math.Pow((y1 - y2), 2));
            b = Math.Sqrt(Math.Pow((x2 - x3), 2) + Math.Pow((y2 - y3), 2));
            c = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
            k1 = Math.Sqrt(Math.Pow((x1 - x), 2) + Math.Pow((y1 - y), 2));
            k2 = Math.Sqrt(Math.Pow((x2 - x), 2) + Math.Pow((y2 - y), 2));
            k3 = Math.Sqrt(Math.Pow((x3 - x), 2) + Math.Pow((y3 - y), 2));
            p = (a + b + c) / 2.0;
            p1 = (a + k1 + k2) / 2.0;
            p2 = (b + k2 + k3) / 2.0;
            p3 = (c + k1 + k3) / 2.0;
            s = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            s1 = Math.Sqrt(p1 * (p1 - a) * (p1 - k1) * (p1 - k2));
            s2 = Math.Sqrt(p2 * (p2 - k2) * (p2 - b) * (p2 - k3));
            s3 = Math.Sqrt(p3 * (p3 - k3) * (p3 - k1) * (p3 - c));
            double S = (s1 + s2 + s3);
            if (s == S)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
                Console.WriteLine($"s = {s}\ns1 + s2 + s3 = {S}");
            }
        }
    }
}

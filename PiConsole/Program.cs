using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            double piViet = 0, n = 50, x = 0, resV = 1;
            for(int i = 0; i <= n; i++)
            {
                x = Math.Pow(0.5 + 0.5 * x, 1.0 / 2);
                resV = resV * x;
            }
            piViet = 2.0 / resV;
            Console.WriteLine(piViet);
            double V = Math.Abs(Math.PI - piViet);


            double piWallis = 0, resW = 1;
            for(int i = 1; i <= 2 * n; i += 2)
            {
                resW = resW * (i * (i + 2)) / ((i + 1) * (i + 1));
                piWallis = 2.0 / resW;
            }
            Console.WriteLine(piWallis);
            double W = Math.Abs(Math.PI - piWallis);


            double piBrouncker = 0, yB = 0, resB = 1;
            if(n % 2 != 0)
            {
                n = n + 1;
            }
            for(int i = 1;i <= n; i += 2)
            {
                yB = ((n - i) * (n - i)) / (2 + yB);
                resB = 1 + yB;
                piBrouncker = 4 / resB;
            }
            Console.WriteLine(piBrouncker);
            double B = Math.Abs(Math.PI - piBrouncker);


            double piLeibnic = 0, resL = 0, xL = 0;
            for(double i = 1; i <= n; i++)
            {
                xL = Math.Pow(-1, i + 1) / (2.0 * i - 1);
                resL = resL + xL;
            }
            piLeibnic = 4.0 * resL;
            Console.WriteLine(piLeibnic);
            double L = Math.Abs(Math.PI - piLeibnic);
            if(W < B && W < L && W < V)
            {
                Console.WriteLine($"Самое точное вычисление у Уоллиса");
            }else if(V < W && V < B && V < L)
            {
                Console.WriteLine($"Самое точное вычисление у Виета");
            }else if(B < V && B < W && B < L)
            {
                Console.WriteLine($"Самое точное вычисление у Бронкера");
            }
            else
            {
                Console.WriteLine($"Самое точное вычисление у Лейбница");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole2
{
    class Program
    {
        static void Main(string[] args)
        {
            int p, i = 1;
            double s = 10;
            Console.WriteLine("Введите p");
            p = Convert.ToInt32(Console.ReadLine());
            while (s < 200)
            {
                s = s + (s * p) / 100;
                i++;
            }
            Console.WriteLine($"За {i} дней спортсмен пробежал {s} км");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, res = 1;
            Console.WriteLine("Введите 2 числа");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= b - a; i++)
            {
                res = res * (a + i);
            }
            Console.WriteLine(res);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double a, res = 1;
            Console.WriteLine("Введите число");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите степень");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                res = res * a;
            }
            Console.WriteLine(res);
        }
    }
}

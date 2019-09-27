using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole6
{
    class Program
    {
        static void Main(string[] args)
        {
            double n, res = 0, a = 1;
            Console.WriteLine("Введите n");
            n = Convert.ToDouble(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                res = res + Math.Pow(a, n - i);
                a++;
            }
            Console.WriteLine(res);
        }
    }
}

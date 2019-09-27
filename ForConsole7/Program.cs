using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole7
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k;
            double res = 0;
            Console.WriteLine("Введите n и k");
            n = Convert.ToInt32(Console.ReadLine());
            k = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <= n; i++)
            {
                res = res + Math.Pow(i, k);
            }
            Console.WriteLine(res);
        }
    }
}

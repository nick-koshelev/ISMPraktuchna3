using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForConsole5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            double res = 0, fact = 1;
            Console.WriteLine("Введите n");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                fact = fact * i;
                res = res + fact;
            }
            Console.WriteLine(res);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k = 0;
            Console.WriteLine("Введите n");
            n = Convert.ToInt32(Console.ReadLine());
            while (Math.Pow(3, k) <= n) {
                k++;
            }
            Console.WriteLine(k);
        }
    }
}

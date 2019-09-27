using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileConsole1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, k = 0;
            Console.WriteLine("Вводите числа");
            do
            {
                n = Convert.ToInt32(Console.ReadLine());
                k = k + n;
            } while (n != 0);
            Console.WriteLine(k);

        }
    }
}

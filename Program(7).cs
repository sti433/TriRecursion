using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication144
{
    class Program
    {
        static void ShowMultiples(int n)
        {
            if (n < 3) return;

            ShowMultiples(n - 3);
            if ((n - (n % 3)) != 0)
                Console.Write((n - (n % 3)) + " ");
        }

        static void Main(string[] args)
        {
            Console.Write("add: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("mezrab:");
            ShowMultiples(n);
            Console.ReadKey();
        }
    }
}

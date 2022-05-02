using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1 = 7, x2 = 1, y1 = 8, y2 = 8;
            int a1 = 7, a2 = 1, b1 = 8, b2 = 8;
            int Line1 = (int)Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            int Line2 = (int)Math.Sqrt((Math.Pow(a1 - a2, 2) + Math.Pow(b1 - b2, 2)));

            Console.WriteLine(Line1);
            Console.WriteLine(Line1);
            if (Line1 == Line2)
                Console.WriteLine("Two Lines are equal");
            else
                Console.WriteLine("Two Line are not equal");
            Console.ReadLine();
        }
    }
}
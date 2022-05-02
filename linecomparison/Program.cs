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
            int x1 = 7, x2 = 2, y1 = 8, y2 = 8;
            int a1 = 7, a2 = 1, b1 = 7, b2 = 2;
            int Line1 = (int)Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            int Line2 = (int)Math.Sqrt((Math.Pow(a1 - a2, 2) + Math.Pow(b1 - b2, 2)));

            Console.WriteLine(Line1);
            Console.WriteLine(Line2);
            if (Line1 == Line2)
                Console.WriteLine("Line1 is equal to Line2");
            else if (Line1 < Line2)
                Console.WriteLine("Line1 is less than Line2");
            else
                Console.WriteLine("Line1 is greater than Line2");
            Console.ReadLine();
        }
    }
}
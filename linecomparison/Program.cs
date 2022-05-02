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
            int Line1 = (int)Math.Sqrt((Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)));
            Console.WriteLine(Line1);
            Console.ReadLine();
        }
    }
}
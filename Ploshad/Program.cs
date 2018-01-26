using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ploshad
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.141;
            double r = 5, s = 0;
            s = pi * Math.Pow(r, 2);
            Console.WriteLine(s);
            Console.ReadLine();
        }
    }
}

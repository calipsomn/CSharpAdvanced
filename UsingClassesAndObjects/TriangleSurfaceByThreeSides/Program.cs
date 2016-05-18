using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSurfaceByThreeSides
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double s = (a + b + c) / 2.0;
            Console.WriteLine(Math.Sqrt(s * (s - a) * (s - b) * (s - c)).ToString("0.00"));
        }
    }
}

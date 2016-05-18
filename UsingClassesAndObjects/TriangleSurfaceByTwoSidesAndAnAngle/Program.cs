using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSurfaceByTwoSidesAndAnAngle
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            var sinC = Math.Sin(c * Math.PI / 180.0);
            Console.WriteLine(((a * b *sinC) / 2.0).ToString("0.00"));
        }
    }
}

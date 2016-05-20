using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleSurfaceBySideAndAltitude
{
    class Program
    {
        static void Main(string[] args)
        {
            double length = double.Parse(Console.ReadLine());
            double altitude = double.Parse(Console.ReadLine());
            Console.WriteLine(((length*altitude)/2.0).ToString("0.00"));
        }
    }
}

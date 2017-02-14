using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(2, 5);
            Point point2 = new Point(4, 9);

            Edge edge = new Edge(point1, point2);

            Console.WriteLine(edge.Lenght);
        }
    }
}

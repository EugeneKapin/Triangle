using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    static class Average
    {
        public static double Perimeter(Triangle[] trianglemass)
        {
            int count = 0;
            double perimeter = 0;
            foreach (Triangle triangle in trianglemass)
            {
                if (triangle.CheckRight())
                {
                    count++;
                    perimeter += triangle.Perimeter;
                }
            }
            return count != 0 ? perimeter / count : 0;
        }

        public static double Area(Triangle[] trianglemass)
        {
            int count = 0;
            double area = 0;
            foreach (Triangle triangle in trianglemass)
            {
                if (triangle.CheckIsosceles())
                {
                    count++;
                    area += triangle.Area;
                }
            }
            return count != 0 ? area / count : 0;
        }
    }
}

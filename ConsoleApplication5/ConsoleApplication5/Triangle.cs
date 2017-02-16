using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Triangle
    {
        Edge One;
        Edge Two;
        Edge Three;
        double perimeter;
        double area;

        public Triangle (Point pointfirst, Point pointsecond, Point pointthird)
        {

            try
            {
                if (!Check(pointfirst, pointsecond, pointthird))
                {
                    throw new TriangleNotExistException();
                }

            }
            catch (TriangleNotExistException ex)
            {
                Console.WriteLine(ex.Exept);
                System.Environment.Exit(0);
            }

            One = new Edge(pointfirst, pointsecond);
            Two = new Edge(pointfirst, pointthird);
            Three = new Edge(pointsecond, pointthird);

            perimeter = Perimeter;
            area = Area;
            CheckIsosceles();
            CheckRight();
        }

        private static bool Check(Point pointfirst, Point pointsecond, Point pointthird)
        {
            Edge edge1 = new Edge(pointfirst, pointsecond);
            Edge edge2 = new Edge(pointfirst, pointthird);
            Edge edge3 = new Edge(pointsecond, pointthird);

            if ((edge1.Lenght + edge2.Lenght > edge3.Lenght) || (edge2.Lenght + edge3.Lenght > edge1.Lenght) || (edge1.Lenght + edge3.Lenght > edge2.Lenght))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public class TriangleNotExistException : Exception
        {

            public string Exept
            {
                get
                {
                    return "Такой треугольник не существует";
                }
            }
        }

        public double Perimeter
        {
            get
            {
                perimeter = (One.Lenght + Two.Lenght + Three.Lenght);
                return perimeter;
            }
        }

        public double Area
        {
            get
            {
               double polper = perimeter / 2;
                area = Math.Sqrt(polper * (polper - One.Lenght) * (polper - Two.Lenght) * (polper * Three.Lenght));
                return area;
            }
        }

        public bool CheckIsosceles()
        {
                return One.Lenght == Two.Lenght || Two.Lenght == Three.Lenght || One.Lenght == Three.Lenght;
        }

        public bool CheckRight()
        {
                return One.Lenght == Math.Sqrt(Two.Lenght * Two.Lenght + Three.Lenght * Three.Lenght) 
                    || Two.Lenght == Math.Sqrt(One.Lenght * One.Lenght + Three.Lenght * Three.Lenght)
                    || Three.Lenght == Math.Sqrt(Two.Lenght * Two.Lenght + One.Lenght * One.Lenght);
        }
    }  
}
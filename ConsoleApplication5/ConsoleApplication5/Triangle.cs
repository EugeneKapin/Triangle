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
        double polper;
        double area;

        public Triangle(Point pointfirst, Point pointsecond, Point pointthird)
        {
            One = new Edge(pointfirst, pointsecond);
            Two = new Edge(pointsecond, pointthird);
            Three = new Edge(pointfirst, pointthird);

            GetPerimeter();
            GetArea();
        }

        public void GetPerimeter()
        {
            perimeter = (One.Lenght + Two.Lenght + Three.Lenght);

        }

        public double Perimeter
        {
            get
            {
                return perimeter;
            }
        }

        public void GetPolper()
        {
            polper = perimeter / 2;
        }

        public double Polper
        {
            get
            {
                return polper;
            }
        }

        public void GetArea()
        {
            area = Math.Sqrt(Polper * (Polper - One.Lenght) * 
                (Polper - Two.Lenght) * (Polper * Three.Lenght));
        }

        public double Area
        {
            get
            {
                return area;
            }
        }

        public bool Isosceles()
        {
            if ((One.Lenght == Two.Lenght) || (One.Lenght == Three.Lenght) || (Two.Lenght == Three.Lenght))
            {
                return true;
            }
            else return false;
        }

        public bool Right()
        {
            if ((One.Lenght < Two.Lenght + Three.Lenght) || (Two.Lenght < One.Lenght + Three.Lenght) ||
                    (Three.Lenght < Two.Lenght + One.Lenght))
            {
                return true;
            }
            else return false;
        }
    }
}

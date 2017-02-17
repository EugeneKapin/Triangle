using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Edge
    {
        public readonly Point First;
        public readonly Point Second;
        double lenght;

        public Edge(Point pointfirst, Point pointsecond)
        {
            First = pointfirst;
            Second = pointsecond;
            CaculateEdgeLenght();
        }
        public static bool operator ==(Edge a, Edge b)
        {
            return a.First == b.First && a.Second == b.Second ||
                   a.First == b.Second && a.Second == b.First;
        }
        public static bool operator !=(Edge a, Edge b)
        {
            return !(a.First == b.First && a.Second == b.Second ||
                     a.First == b.Second && a.Second == b.First);
        }

        public double CaculateEdgeLenght()
        {
            return lenght = Math.Sqrt(Math.Pow((First.X - Second.X), 2) + Math.Pow((First.Y - Second.Y), 2));
        }

        public double Lenght
        {
            get
            {
                return lenght;
            }
        }
    }
}

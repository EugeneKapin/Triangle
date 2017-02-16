using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.IO;

namespace ConsoleApplication5
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle[] trianglemass = Reader.Read("Data.txt");
            Console.WriteLine(Average.Area(trianglemass));
            Console.WriteLine(Average.Perimeter(trianglemass));
        }
    }
}

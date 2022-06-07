using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            Point p2 = new Point(4, 5, '#');

            p1.Draw();
            p2.Draw();

            HorizontalLine HL = new HorizontalLine(2, 40, 7, '#');
            HL.Draw();

            VerticalLine VL = new VerticalLine(2, 7, 20, '#');
            VL.Draw();

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal struct Point
    {
        public double X { get; set; }
        public double Y { get; set; }


        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }

        public double Distance(Point point2)
        {
            double dx = X - point2.X;
            double dy = Y - point2.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

    }
}

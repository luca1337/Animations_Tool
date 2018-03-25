using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace WindowsFormsApp1
{
    public static class ExtensionMethod
    {

        public static Point VectorToPoint(this Vector2 one)
        {
            float x = one.X;
            float y = one.Y;
            Point toReturn = new Point((int)x,(int)y);
            return toReturn;
        }

        public static Vector2 PointToVector(this Point one)
        {
            float x = one.X;
            float y = one.Y;
            Vector2 toReturn = new Vector2(x, y);
            return toReturn;
        }

        public static Point Sum(this Point a, Point b)
        {
            Point toReturn;
            int x = a.X + b.X;
            int y = a.Y + b.Y;

            toReturn = new Point(x,y);
            return toReturn;
        }

        public static Point Difference(this Point a, Point b)
        {
            Point toReturn;
            int x = a.X - b.X;
            int y = a.Y - b.Y;

            toReturn = new Point(x, y);
            return toReturn;
        }
    }
}

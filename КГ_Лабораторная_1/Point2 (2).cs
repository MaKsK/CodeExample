using System.Drawing;

namespace КГ_Лабораторная_1
{
     class Point2
    {
        public float x;
        public float y;
    
        public Point2(float X, float Y)
        {
            x = X;
            y = Y;
        }
        public Point ToScrenPoint(Point2 O)
        {
            return new Point((int)(O.x + x), (int)(O.y - y));
        }
    }
}
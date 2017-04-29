using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace КГ_Лабораторная_1
{
    abstract class Drawing  
    {
        public Point2 OScren;
        public float alpha;

        public Drawing(Point2 OScren, float alpha)
        {
            this.OScren = OScren;
            this.alpha = alpha;
        }

        public abstract void Draw(Graphics graphics);
        public abstract void DrawXYZ(Graphics graphics);

        public void DrawPoint2(Point2 point,Color color, string namePoint, Graphics graphics)
        {
            //Рисуем  точку  и подписываем её
            Point p = point.ToScrenPoint(OScren);
            graphics.FillEllipse(new SolidBrush(color), p.X - 2, p.Y - 2, 5, 5);
            Font font = new Font("Arial", 9);
            graphics.DrawString(namePoint, font, new SolidBrush(Color.Black), p.X + 1, p.Y + 1);
        }
        public void DrawPoint3(Point3 point, Color color, string namePoint, Graphics graphics)
        {
            //Рисуем  точку  и подписываем её
            Point p = point.ToSpatialDrawingScrenPoint(alpha, OScren);
            graphics.FillEllipse(new SolidBrush(color), p.X - 2, p.Y - 2, 5, 5);
            Font font = new Font("Arial", 9);
            graphics.DrawString(namePoint, font, new SolidBrush(Color.Black), p.X + 1, p.Y + 1);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КГ_Лабораторная_1
{
    class Converter
    {
        public event Action<object> AngleChanged;
        float alpha;
        float beta;
        float gama;
        Point oScren;
        public float Alpha
        {
            get
            {
                return alpha;
            }
            set
            {
                alpha = value;
                AngleChanged(this);
            }
        }
        public float Beta
        {
            get
            {
                return beta;
            }
            set
            {
                beta = value;
                AngleChanged(this);
            }
        }
        public float Gama
        {
            get
            {
                return gama;
            }
            set
            {
                gama = value;
                AngleChanged(this);
            }
        }
        public Converter(float alpha,float beta,float gama, Point oScren)
        {
            this.alpha = alpha;
            this.beta = beta;
            this.gama = gama;
            this.oScren = oScren;
        }
        private Point ToScrenPoint(Point p)
        {
            int x = oScren.X - p.X;
            int y = oScren.Y - p.Y;
            return new Point(x, y);
        }
        public Point ToComplexDrawingXYScrenPoint(Point3 p)
        {
            return ToScrenPoint(new Point((int)p.X, (int)-p.Y));
        }
        public Point ToComplexDrawingXZScrenPoint(Point3 p)
        {
            return ToScrenPoint(new Point((int)p.X, (int)p.Z));
        }
        public Point ToComplexDrawingYZScrenPoint(Point3 p)
        {
            return ToScrenPoint(new Point((int)-p.Y, (int)p.Z));
        }
        public Point ToSpatialDrawingScrenPoint(Point3 p)
        { 
            int x = (int)Math.Round((oScren.X - p.X * Math.Cos(alpha) - p.Y * Math.Cos(beta) - p.Z * Math.Cos(gama)));
            int y = (int)Math.Round((oScren.Y + p.X * Math.Sin(alpha) + p.Y * Math.Sin(beta) + p.Z * Math.Sin(gama)));
            return new Point(x,y);
        }
        public void Input(float alpha, float beta, float gama)
        {
            this.alpha = alpha;
            this.beta = beta;
            this.gama = gama;
            
        }
    }
}

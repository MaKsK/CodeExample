using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КГ_Лабораторная_1
{
    class Point3: IEquatable<Point3>
    {
        //Событие возникающие при изминение координаты точки
        public event Action<object> CoordinateChanged;

        float x;
        float y;
        float z;
        public float X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
                CoordinateChanged(this);
            }
        }
        public float Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
                CoordinateChanged(this);
            }
        }
        public float Z
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
                CoordinateChanged(this);
            }
        }
        public Point3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public void Input(float x,float y,float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            
        }

        public bool Equals(Point3 other)
        {
            return (other.X == x && other.Y == y && other.Z == z);
        }
    }
}

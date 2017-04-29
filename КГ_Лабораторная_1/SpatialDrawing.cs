using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace КГ_Лабораторная_1
{
    class SpatialDrawing : Drawing
    {
        const int N=14;
        

        Point3[] points_3d=new Point3[N];
        Point[] points_2d = new Point[N];

        List<Tuple<int, int,Pen>> Lines = new List<Tuple<int, int,Pen>>();
        List<Tuple<int, int, Pen>> Axes = new List<Tuple<int, int, Pen>>();
        public SpatialDrawing(Converter converter) : base(converter) 
        {
            Pen pen = new Pen(Color.Gray);
            Lines.Add(new Tuple<int, int, Pen>(0, 2, pen)); //T-T1
            Lines.Add(new Tuple<int, int, Pen>(0, 3, pen)); //T-T2
            Lines.Add(new Tuple<int, int, Pen>(0, 4, pen)); //T-T3

            Lines.Add(new Tuple<int, int, Pen>(2, 5, pen)); //T1-Tx
            Lines.Add(new Tuple<int, int, Pen>(2, 6, pen)); //T1-Ty
            Lines.Add(new Tuple<int, int, Pen>(3, 5, pen)); //T2-Tx
            Lines.Add(new Tuple<int, int, Pen>(3, 7, pen)); //T2-Tz
            Lines.Add(new Tuple<int, int, Pen>(4, 6, pen)); //T3-Ty
            Lines.Add(new Tuple<int, int, Pen>(4, 7, pen)); //T3-Tz

            pen = new Pen(Color.Red);
            pen.EndCap = LineCap.ArrowAnchor;
            Axes.Add(new Tuple<int, int, Pen>(1, 8, pen)); //xBegin-O
            pen = new Pen(Color.Green);
            pen.EndCap = LineCap.ArrowAnchor;
            Axes.Add(new Tuple<int, int, Pen>(1, 9, pen)); //yBegin-O
            pen = new Pen(Color.Blue);
            pen.EndCap = LineCap.ArrowAnchor;
            Axes.Add(new Tuple<int, int, Pen>(1, 10, pen)); //zBegin-O

            pen = new Pen(Color.Red);
            pen.DashStyle = DashStyle.Dash;
            Axes.Add(new Tuple<int, int, Pen>(11, 1, pen)); //xEnd-O
            pen = new Pen(Color.Green);
            pen.DashStyle = DashStyle.Dash;
            Axes.Add(new Tuple<int, int, Pen>(12, 1, pen)); //yEnd-O
            pen = new Pen(Color.Blue);
            pen.DashStyle = DashStyle.Dash;
            Axes.Add(new Tuple<int, int, Pen>(13, 1, pen)); //zEnd-O
        }
        
        public void Update()
        {
           for(int i=0;i<N;i++) 
           {
               points_2d[i]=converter.ToSpatialDrawingScrenPoint(points_3d[i]);
           }
        }
        // 0 - T
        // 1 - O
        // 2 - T1
        // 3 - T2
        // 4 - T3
        // 5 - Tx
        // 6 - Ty
        // 7 - Tz
        // 8 - xBegin
        // 9 - yBegin
        // 10 - zBegin
        // 11 - xEnd
        // 12 - yEnd
        // 13 - zEnd
        public override void Draw(Graphics graphics)
        {
            
            //Отрисовка осей координат
            DrawAxes(graphics);

            foreach (Tuple<int, int, Pen> t in Lines)
            {
                graphics.DrawLine(t.Item3, points_2d[t.Item1], points_2d[t.Item2]);
            }

            //Отрисовка точек
            DrawPoint(points_2d[1], Color.Coral, "O", graphics);

            DrawPoint(points_2d[0], Color.Brown, "T", graphics);

            DrawPoint(points_2d[2], Color.Brown, "T1", graphics);
            DrawPoint(points_2d[3], Color.Brown, "T2", graphics);
            DrawPoint(points_2d[4], Color.Brown, "T3", graphics);

            DrawPoint(points_2d[5], Color.Brown, "Tx", graphics);
            DrawPoint(points_2d[6], Color.Brown, "Ty", graphics);
            DrawPoint(points_2d[7], Color.Brown, "Tz", graphics);
        }

        public override void DrawAxes(Graphics graphics)
        {
            
          
            //Отрисовываем оси координат
            foreach(Tuple<int,int,Pen> t in Axes)
            {
                graphics.DrawLine(t.Item3, points_2d[t.Item1], points_2d[t.Item2]);
            }
            //Подписываем оси координат
            Font font = new Font("Arial", 9);
            graphics.DrawString("X", font, new SolidBrush(Color.Black), points_2d[8].X + 1, points_2d[8].Y + 1);
            graphics.DrawString("Y", font, new SolidBrush(Color.Black), points_2d[9].X + 1, points_2d[9].Y + 1);
            graphics.DrawString("Z", font, new SolidBrush(Color.Black), points_2d[10].X + 1, points_2d[10].Y + 1);
        }
        // 0 - T
        // 1 - O
        // 2 - T1
        // 3 - T2
        // 4 - T3
        // 5 - Tx
        // 6 - Ty
        // 7 - Tz
        // 8 - xBegin
        // 9 - yBegin
        // 10 - zBegin
        // 11 - xEnd
        // 12 - yEnd
        // 13 - zEnd
       public void InputPoints(Point3[] points)
       {
           points_3d = points;
       }
       public void InputAngle(float alpha,float beta,float gamma)
       {
            converter.Input(alpha, beta, gamma);
       }
       
    }
}

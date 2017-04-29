using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace КГ_Лабораторная_1
{
    
    class ComplexDrawing : Drawing
    {
        const int N = 14;
        
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
        Point3[] points_3d = new Point3[N];
        Point[] points_2d = new Point[N];

        List<Tuple<int, int, Pen>> Lines = new List<Tuple<int, int, Pen>>();
        List<Tuple<int, int, Pen>> Axes = new List<Tuple<int, int, Pen>>();
        public ComplexDrawing(Converter converter) : base(converter)
        {
            Pen pen = new Pen(Color.Gray);
            Lines.Add(new Tuple<int, int, Pen>(2, 5, pen)); //T1-Tx
            Lines.Add(new Tuple<int, int, Pen>(2, 6, pen)); //T1-Ty1
            Lines.Add(new Tuple<int, int, Pen>(3, 5, pen)); //T2-Tx
            Lines.Add(new Tuple<int, int, Pen>(3, 8, pen)); //T2-Tz
            Lines.Add(new Tuple<int, int, Pen>(4, 8, pen)); //T3-Tz
            Lines.Add(new Tuple<int, int, Pen>(4, 7, pen)); //T3-Ty2

            pen = new Pen(Color.Red);
            pen.EndCap = LineCap.ArrowAnchor;
            Axes.Add(new Tuple<int, int, Pen>(1, 9, pen)); //O-xBegin
            pen = new Pen(Color.Green);
            pen.EndCap = LineCap.ArrowAnchor;
            Axes.Add(new Tuple<int, int, Pen>(1, 10, pen)); //O-y1Begin
            Axes.Add(new Tuple<int, int, Pen>(1, 11, pen)); //O-t2Begin
            pen = new Pen(Color.Blue);
            pen.EndCap = LineCap.ArrowAnchor;
            Axes.Add(new Tuple<int, int, Pen>(1, 12, pen)); //O-zBegin
        }
        
        public void Update()
        {


            //Вычисляем экранные координаты точек

            // 0 - T
            // 1 - O
            // 2 - T1
            // 3 - T2
            // 4 - T3
            // 5 - Tx
            // 6 - Ty1
            // 7- Ty2
            // 8 - Tz
            // 9 - xBegin
            // 10 - y1Begin
            // 11 - y2Begin
            // 12 - zBegin


            points_2d[1] = converter.ToComplexDrawingXYScrenPoint(points_3d[1]);
            points_2d[2] = converter.ToComplexDrawingXYScrenPoint(points_3d[2]);
            points_2d[3] = converter.ToComplexDrawingXZScrenPoint(points_3d[3]);
            points_2d[4] = converter.ToComplexDrawingYZScrenPoint(points_3d[4]);
            points_2d[5] = converter.ToComplexDrawingXYScrenPoint(points_3d[5]);
            points_2d[6] = converter.ToComplexDrawingXYScrenPoint(points_3d[6]);
            points_2d[7] = converter.ToComplexDrawingYZScrenPoint(points_3d[6]);
            points_2d[8] = converter.ToComplexDrawingYZScrenPoint(points_3d[7]);
            points_2d[9] = converter.ToComplexDrawingXYScrenPoint(points_3d[8]);
            points_2d[10] = converter.ToComplexDrawingXYScrenPoint(points_3d[9]);
            points_2d[11] = converter.ToComplexDrawingYZScrenPoint(points_3d[9]);
            points_2d[12] = converter.ToComplexDrawingYZScrenPoint(points_3d[10]);

        }

        public override void Draw(Graphics graphics)
        {
           
            //Отрисовка осей координат
            DrawAxes(graphics);


            //Отрисовка линий связи между проекциями на плоскости и проекциями на оси координат
            foreach (Tuple<int, int, Pen> t in Lines)
            {
                graphics.DrawLine(t.Item3, points_2d[t.Item1], points_2d[t.Item2]);
            }
            
            //Отрисовки полуокружности
            if (points_3d[0].Y>0) graphics.DrawArc(new Pen(Color.Gray, 1), points_2d[1].X- points_3d[0].Y, points_2d[1].Y - points_3d[0].Y, 2* points_3d[0].Y,2* points_3d[0].Y,(float)(0), (float)(90));
            else if(points_3d[0].Y<0) graphics.DrawArc(new Pen(Color.Gray, 1), points_2d[1].X + points_3d[0].Y, points_2d[1].Y + points_3d[0].Y, -2 * points_3d[0].Y, -2 * points_3d[0].Y, (float)(180), (float)(90));

            //Отрисовка точек
            DrawPoint(points_2d[1], Color.Coral, "O", graphics);

            DrawPoint(points_2d[2], Color.Brown, "T1", graphics);
            DrawPoint(points_2d[3], Color.Brown, "T2", graphics);
            DrawPoint(points_2d[4], Color.Brown, "T3", graphics);

            DrawPoint(points_2d[5], Color.Brown, "Tx", graphics);
            DrawPoint(points_2d[6], Color.Brown, "Ty1", graphics);
            DrawPoint(points_2d[7], Color.Brown, "Ty2", graphics);
            DrawPoint(points_2d[8], Color.Brown, "Tz", graphics);
        }

        public override void DrawAxes(Graphics graphics)
        {

            //Отрисовка осей координат
            foreach (Tuple<int, int, Pen> t in Axes)
            {
                graphics.DrawLine(t.Item3, points_2d[t.Item1], points_2d[t.Item2]);
            }

            //Подписываем оси координат
            Font font = new Font("Arial", 9);
            graphics.DrawString("X", font, new SolidBrush(Color.Black), points_2d[9].X + 1, points_2d[9].Y + 1);
            graphics.DrawString("Y", font, new SolidBrush(Color.Black), points_2d[10].X + 1, points_2d[10].Y + 1);
            graphics.DrawString("Y", font, new SolidBrush(Color.Black), points_2d[11].X + 1, points_2d[11].Y + 1);
            graphics.DrawString("Z", font, new SolidBrush(Color.Black), points_2d[12].X + 1, points_2d[12].Y + 1);
        }
        public void InputPoints(Point3[] T)
        {
            points_3d = T;
        }
        
    }
}

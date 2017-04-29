using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace КГ_Лабораторная_1
{
    public partial class MainForm : Form
    {
        Point3 T;
        SpatialDrawing spatialdrawing;
        ComplexDrawing complexdrawing;

        Converter converter;

        public MainForm()
        {
            InitializeComponent();
            
            //Включаем двойную буфиризацию    
            DoubleBuffered = true;
            //Создаём точку T
            T = new Point3(trackBarX.Value, trackBarY.Value, trackBarZ.Value);
            //oScren центр осей координат в экранных координатах
            Point oScren = new Point(pb_spatiald.Width / 2, pb_spatiald.Height / 2);
            //Создаем объект класса Converter преобразующий 3-ех мерные координаты в экранные 
            converter = new Converter(trackBarA.Value * (float)Math.PI/180, trackBarB.Value * (float)Math.PI / 180, trackBarG.Value * (float)Math.PI / 180, oScren);

            Point3[] points = new Point3[14];
            points[0] = T;
            points[1] = new Point3(0, 0, 0);
            points[2] = new Point3(T.X, T.Y, 0);
            points[3] = new Point3(T.X, 0, T.Z);
            points[4] = new Point3(0, T.Y, T.Z);
            points[5] = new Point3(T.X, 0, 0);
            points[6] = new Point3(0, T.Y, 0);
            points[7] = new Point3(0, 0, T.Z);
            points[8] = new Point3(100, 0, 0);
            points[9] = new Point3(0, 100, 0);
            points[10] = new Point3(0, 0, 100);
            points[11] = new Point3(-100, 0, 0);
            points[12] = new Point3(0, -100, 0);
            points[13] = new Point3(0, 0, -100);

            //Создаём пространственный чертёж 
            spatialdrawing = new SpatialDrawing(converter);
            //Создаём комплесный чертёж
            complexdrawing = new ComplexDrawing(converter);

            //Ввод массива точек
            spatialdrawing.InputPoints(points);
            complexdrawing.InputPoints(points);

            spatialdrawing.Update();
            complexdrawing.Update();
        } 

       
      
        private void XYZControl_ValueChanged(object sender, EventArgs e)
        {
            TrackBar tb = sender as TrackBar;
            Point3 T=new Point3(trackBarX.Value,trackBarY.Value,trackBarZ.Value);
            Point3[] points = new Point3[14];
            points[0] = T;
            points[1] = new Point3(0, 0, 0);
            points[2] = new Point3(T.X, T.Y, 0);
            points[3] = new Point3(T.X, 0, T.Z);
            points[4] = new Point3(0, T.Y, T.Z);
            points[5] = new Point3(T.X, 0, 0);
            points[6] = new Point3(0, T.Y, 0);
            points[7] = new Point3(0, 0, T.Z);
            points[8] = new Point3(100, 0, 0);
            points[9] = new Point3(0, 100, 0);
            points[10] = new Point3(0, 0, 100);
            points[11] = new Point3(-100, 0, 0);
            points[12] = new Point3(0, -100, 0);
            points[13] = new Point3(0, 0, -100);
            

            //Ввод массива точек
            spatialdrawing.InputPoints(points);
            complexdrawing.InputPoints(points);

            //Обновление чертежа
            spatialdrawing.Update();
            complexdrawing.Update();

            //Перерисовка чертежа 
            pb_spatiald.Invalidate();
            pb_complexd.Invalidate();
        }
        private void AngleControl_ValueChanged(object sender, EventArgs e)
        {
            //Обновление углов
            spatialdrawing.InputAngle(trackBarA.Value * (float)Math.PI / 180, trackBarB.Value * (float)Math.PI / 180, trackBarG.Value * (float)Math.PI / 180);

            spatialdrawing.Update();

            pb_spatiald.Invalidate();

        }
        private void pb_spatiald_Paint(object sender, PaintEventArgs e)
        {
            //Отрисовка пространственого чертежа
            spatialdrawing.Draw(e.Graphics);
        }

        private void pb_complexd_Paint(object sender, PaintEventArgs e)
        {
            //Отрисовка комплексного чертежа
            complexdrawing.Draw(e.Graphics);
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            //Выход из программы
            Application.Exit();
        }

        

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace КГ_Лабораторная_1
{
    public partial class ScrollBar : TrackBar
    {
        public ScrollBar()
        {
            InitializeComponent();
            Controls.Add(curentValue);
            Controls.Add(maxValue);
            Controls.Add(minValue);
            Controls.Add(ziroValue);
            
        }
        protected override void OnCreateControl()
        {
            base.OnCreateControl();
            minValue.Text = Minimum.ToString();
            maxValue.Text = Maximum.ToString();
            curentValue.Text = Value.ToString();
            minValue.Location = new Point(0, Height - 26);
            maxValue.Location = new Point(Width - maxValue.Width-3, Height - 26);
            int d = 28;
            int ofset = 15;
            int x = -(curentValue.Width / 2) + ofset + (((Value - Minimum) * (Width - d)) / Math.Abs(Minimum - Maximum));
            int y = Height - curentValue.Height;
            Point p = new Point(x, y);
            curentValue.Location = p;
            if (Minimum*Maximum<0)
            {
               x = -(ziroValue.Width / 2) + ofset + (((- Minimum) * (Width - d)) / Math.Abs(Minimum - Maximum));
               y = Height - ziroValue.Height;
                ziroValue.Location = new Point(x, y);
            }
            else
            {
                ziroValue.Visible = false;
            }
        }
        
        protected override void OnValueChanged(EventArgs e)
        {
            base.OnValueChanged(e);
            curentValue.Text = Value.ToString();
            int d = 28;
            int ofset = 15;
            int x=-(curentValue.Width/2)+ofset+(((Value-Minimum)*(Width- d))/ Math.Abs(Minimum - Maximum));
            int y = Height - curentValue.Height;
            Point p = new Point(x, y);
            curentValue.Location = p;
        }
        
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaint
{
    class Function
    {
        public Function(float sqx, float x, float c)
        {
            A = sqx;
            B = x;
            C = c;
        }

        public float B
        { get; set; }

        public float C
        { get; set; }

        public float A
        { get; set; }

        public void DrawFunction(Graphics g, PictureBox p)
        {          
            Point center = new Point();
            Point start = new Point(), end = new Point();
            center.X = (int)Math.Round(((double)p.Width / 2), MidpointRounding.AwayFromZero);
            center.Y = (int)Math.Round(((double)p.Height / 2), MidpointRounding.AwayFromZero);
            int dot = (-center.X)+ 1;
            start.Y = (int)Math.Round(A * Math.Pow(dot, 2) + B * dot + C, MidpointRounding.AwayFromZero);
            start.X = dot;
            int y;
            for (int i=dot; i<p.Height; i++)
            {
                end.X = i;
                end.Y = (int)Math.Round(A * Math.Pow(i, 2) + B * i + C, MidpointRounding.AwayFromZero);
                g.DrawLine(Pens.Black, start.X + center.X, start.Y * -1 + center.Y, end.X + center.X, end.Y * -1 + center.Y);
                start = end;
                /*
                y = (int)Math.Round(A * Math.Pow(i, 2) + B * i + C, MidpointRounding.AwayFromZero);
                g.DrawRectangle(Pens.Black, i + center.X, y * -1 + center.Y, 1, 1);*/
            }
            p.Invalidate();
        }

        public static void DrawXaxis(Graphics g, PictureBox p)
        {
            int center = (int) Math.Round(((double)p.Height / 2), MidpointRounding.AwayFromZero);
            Point start = new Point(0, center);
            Point end = new Point(p.Size.Width, center);
            g.DrawLine(Pens.Black, start, end);
        }

        public static void DrawYaxis(Graphics g, PictureBox p)
        {
            int center = (int)Math.Round(((double)p.Width / 2), MidpointRounding.AwayFromZero);
            Point start = new Point(center, 0);
            Point end = new Point(center, p.Size.Height);
            g.DrawLine(Pens.Black, start, end);
        }
    }
}

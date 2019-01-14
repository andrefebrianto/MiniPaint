using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MiniPaint
{
    class DDA
    {
        public Point Start { get; set; }

        public Point End { get; set; }

        public int Step { get; }

        public int DelX { get; }

        public int DelY { get; }

        public int AbsDelX { get; }

        public int AbsDelY { get; }

        public float XInc { get; }

        public float YInc { get; }

        public DDA(Point start, Point end)
        {
            Start = start;
            End = end;
            DelX = end.X - start.X;
            DelY = end.Y - start.Y;
            AbsDelX = Math.Abs(DelX);
            AbsDelY = Math.Abs(DelY);
            Step = AbsDelX > AbsDelY ? AbsDelX : AbsDelY;
            if (DelX != 0 && DelY != 0)
            {
                XInc = (float) DelX / Step;
                YInc = (float) DelY / Step;
            }
        }

        public void DrawLine(Graphics g, PictureBox area)
        {
            float X = Start.X, Y = Start.Y;
            Point start = Start, end = Point.Empty;

            Pen pen = new Pen(Color.Black);
            for (int i = 1; i <= Step; i++)
            {
                X += XInc;
                end.X = (int)Math.Round(X, MidpointRounding.AwayFromZero);

                Y += YInc;
                end.Y = (int)Math.Round(Y, MidpointRounding.AwayFromZero);
                g.DrawLine(pen, start, end);
                //g.DrawRectangle(pen, start.X, start.Y, 1, 1);
                start = end;
                area.Invalidate();
            }
            
        }
    }
}

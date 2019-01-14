using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaint
{
    class Bresenham
    {
        public Bresenham(Point start, Point end)
        {
            Start = start;
            End = end;
            DelX = end.X - start.X;
            DelY = end.Y - start.Y;
            AbsDelX = Math.Abs(DelX);
            AbsDelY = Math.Abs(DelY);
            Step = AbsDelX > AbsDelY ? AbsDelX : AbsDelY;
        }

        public Point Start
        { get; set; }

        public Point End
        { get; set; }

        public int DelX
        { get; }

        public int DelY
        { get; }

        public int AbsDelX
        { get; }

        public int AbsDelY
        { get; }

        public int Step
        { get; }

        public void DrawLine(Graphics g, PictureBox p)
        {
            Point end = Start, start = Start;
            Pen pen = new Pen(Color.Red);
            int Pk, ver = 1, hor = 1;

            if (DelY < 0)
                ver = -1;
            if (DelX < 0)
                hor = -1;
            if (AbsDelX > AbsDelY)
            {
                Pk = 2 * DelY - DelX;
                for (int i = 1; i <= AbsDelX; i++)
                {
                    end.X += 1 * hor;
                    end.Y = (Pk < 0) ? end.Y : end.Y + 1 * ver;
                    g.DrawLine(pen, start, end);
                    Pk = (Pk < 0) ? Pk + 2 * DelY * ver : Pk + 2 * DelY * ver - 2 * DelX * hor;
                    start = end;
                }
            }
            else
            {
                Pk = 2 * DelX - DelY;
                for (int i = 1; i <= AbsDelY; i++)
                {
                    end.Y += 1 * ver;
                    end.X = (Pk < 0) ? end.X : end.X + 1 * hor;
                    g.DrawLine(pen, start, end);
                    Pk = (Pk < 0) ? Pk + 2 * DelX * hor : Pk + 2 * DelX * hor - 2 * DelY * ver;
                    start = end;
                }
            }
            p.Invalidate();
        }
    }
}
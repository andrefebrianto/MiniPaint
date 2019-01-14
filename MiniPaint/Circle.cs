using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MiniPaint
{
    class Circle
    {
        public Circle(Point start, Point end)
        {
            Center = start;
            Radius = (int)Math.Sqrt(Math.Pow(end.X - start.X, 2) + Math.Pow(end.Y - start.Y, 2));
        }

        public int Radius
        { get; }

        public Point Center
        { get; }

        public void DrawCircle(Graphics g, PictureBox p)
        {
            int x = 0;
            int y = Radius;
            int Pk = 1 - Radius;
            Pen pen = new Pen(Color.Purple);

            while(x < y)
            {
                /*rumus kotak
                g.DrawRectangle(pen, Center.X + x, Center.Y + y, 1, 1);
                g.DrawRectangle(pen, Center.X + y, Center.Y + x, 1, 1);
                g.DrawRectangle(pen, Center.X + x, Center.Y - y, 1, 1);
                g.DrawRectangle(pen, Center.X + y, Center.Y - x, 1, 1);
                g.DrawRectangle(pen, Center.X - x, Center.Y + y, 1, 1);
                g.DrawRectangle(pen, Center.X - y, Center.Y + x, 1, 1);
                g.DrawRectangle(pen, Center.X - x, Center.Y - y, 1, 1);
                g.DrawRectangle(pen, Center.X - y, Center.Y - x, 1, 1);             

                x++;
                Pk = (Pk <  0) ? Pk + 2 * x + 1 : Pk + 2 * x + 1 - 2 * y;
                y  = (Pk >= 0) ? y-- : y;
                */

                g.DrawRectangle(pen, Center.X + x, Center.Y + y, 1, 1);
                g.DrawRectangle(pen, Center.X + y, Center.Y + x, 1, 1);
                g.DrawRectangle(pen, Center.X + x, Center.Y - y, 1, 1);
                g.DrawRectangle(pen, Center.X + y, Center.Y - x, 1, 1);
                g.DrawRectangle(pen, Center.X - x, Center.Y + y, 1, 1);
                g.DrawRectangle(pen, Center.X - y, Center.Y + x, 1, 1);
                g.DrawRectangle(pen, Center.X - x, Center.Y - y, 1, 1);
                g.DrawRectangle(pen, Center.X - y, Center.Y - x, 1, 1);

                x++;
                if (Pk < 0)
                    Pk = Pk + 2 * x + 1;
                else
                {
                    y--;
                    Pk = Pk + 2 * x + 1 - 2 * y;
                }
            }
            p.Invalidate();
        }
    }
}

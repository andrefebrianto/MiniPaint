using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MiniPaint
{
    class Ellipse
    {
        public Ellipse(Point start, Point end)
        {
            Center = start;
            RadiusMaj = Math.Abs(end.Y - start.Y);
            RadiusMin = Math.Abs(end.X - start.X);
        }

        public Point Center
        { get; }

        public int RadiusMaj
        { get; }

        public int RadiusMin
        { get; }

        public void DrawEllipse(Graphics g, PictureBox p)
        {
            Pen pen = new Pen(Color.Orange);
            int a2 = (int) Math.Pow(RadiusMin, 2); 
            int b2 = (int) Math.Pow(RadiusMaj, 2);
            int fa2 = 4 * a2, fb2 = 4 * b2;
            int x, y, sigma;

            if (RadiusMaj == 0 || RadiusMin == 0)
            {
                return;
            }

            /* first half */
            for (x = 0, y = RadiusMaj, sigma = 2 * b2 + a2 * (1 - 2 * RadiusMaj); b2 * x <= a2 * y; x++)
            {
                g.DrawRectangle(pen, Center.X + x, Center.Y + y, 1, 1);
                g.DrawRectangle(pen, Center.X - x, Center.Y + y, 1, 1);
                g.DrawRectangle(pen, Center.X + x, Center.Y - y, 1, 1);
                g.DrawRectangle(pen, Center.X - x, Center.Y - y, 1, 1);
                if (sigma >= 0)
                {
                    sigma += fa2 * (1 - y);
                    y--;
                }
                sigma += b2 * ((4 * x) + 6);
            }

            /* second half */
            for (x = RadiusMin, y = 0, sigma = 2 * a2 + b2 * (1 - 2 * RadiusMin); a2 * y <= b2 * x; y++)
            {
                g.DrawRectangle(pen, Center.X + x, Center.Y + y, 1, 1);
                g.DrawRectangle(pen, Center.X - x, Center.Y + y, 1, 1);
                g.DrawRectangle(pen, Center.X + x, Center.Y - y, 1, 1);
                g.DrawRectangle(pen, Center.X - x, Center.Y - y, 1, 1);
                if (sigma >= 0)
                {
                    sigma += fb2 * (1 - x);
                    x--;
                }
                sigma += a2 * ((4 * y) + 6);
            }
            p.Invalidate();
        }
    }
}

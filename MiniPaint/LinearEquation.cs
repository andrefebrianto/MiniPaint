using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaint
{
    class LinearEquation
    {
        public LinearEquation()
        {
        }

        public LinearEquation(Point start, Point end)
        {
            Start = start;
            End = end;
            DelX = End.X - Start.X;
            DelY = End.Y - Start.Y;
            Gradien = (float)(End.Y - Start.Y) / (End.X - Start.X);
            C = (float)Start.Y - Gradien * Start.X;
        }

        public Point Start
        { get; set; }

        public Point End
        { get; set; }

        public float Gradien
        { get; set; }

        public float C
        { get; set; }

        public int DelX { get; }

        public int DelY { get; }

        public void DrawLine(Graphics g, PictureBox p)
        {
            Pen pen = new Pen(Color.Blue);

            if (Gradien == 0)
            {             
                int x = Math.Min(Start.X,End.X);
                for(int i=0; i<Math.Abs(DelX); i++)
                {
                    g.DrawRectangle(pen, x, Start.Y, 1, 1);
                    x++;
                }
            }
            else if(DelX == 0)
            {
                int y = Math.Min(Start.Y, End.Y);
                for(int i=0; i<Math.Abs(DelY); i++)
                {
                    g.DrawRectangle(pen, Start.X, y, 1, 1);
                    y++;
                }
            }
            else
            {
                Point start = Start, end = new Point();
                if(Math.Abs(Gradien) > 1)
                {
                    start = Start.Y > End.Y ? Start : End;
                    end = start;
                    for(int i=0; i<Math.Abs(DelY); i++)
                    {
                        end.Y--;
                        end.X = (int)Math.Round((end.Y - C) / Gradien, MidpointRounding.AwayFromZero);
                        g.DrawLine(pen, start, end);
                        start = end;
                    }
                }
                else
                {
                    start = Start.X >= End.X ? Start : End;
                    end = start;
                    for (int i = 0; i < Math.Abs(DelX); i++)
                    {
                        end.X--;
                        end.Y = (int)Math.Round(Gradien * end.X + C, MidpointRounding.AwayFromZero);
                        g.DrawLine(pen, start, end);
                        start = end;
                    }
                }
            }
            p.Invalidate();
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MiniPaint
{
    class Star
    {
        public Star(Point start, Point end, int vertex)
        {
            Center = start;
            Radius = (int)Math.Sqrt(Math.Pow(end.X - start.X, 2) + Math.Pow(end.Y - start.Y, 2));
            Vertex = vertex;
        }

        public Point Center
        { get; }

        public int Radius
        { get; }

        public int Vertex
        { get; }

        public void DrawStar(Graphics g, PictureBox p)
        {
            Pen pen = new Pen(Color.Green);
            Point start = new Point();
            Point end = new Point();

            for (int i = 0; i < Vertex; i++)
            {
                start.X = Center.X + (int)(Radius * Math.Cos(Math.PI * 2 / Vertex * i + Math.PI / Vertex));
                start.Y = Center.Y + (int)(Radius * Math.Sin(Math.PI * 2 / Vertex * i + Math.PI / Vertex));

                end.X = Center.X + (int)(Radius * Math.Cos(Math.PI * 2 / Vertex * (i + 2) + Math.PI / Vertex));
                end.Y = Center.Y + (int)(Radius * Math.Sin(Math.PI * 2 / Vertex * (i + 2) + Math.PI / Vertex));
                g.DrawLine(pen, start, end);
            }
            p.Invalidate();
        }
    }
}

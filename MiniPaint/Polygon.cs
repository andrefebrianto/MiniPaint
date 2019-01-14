using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace MiniPaint
{
    class Polygon
    {
        public Polygon(Point start, Point end, int vertex)
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

        public void DrawPolygon(Graphics g, PictureBox p)
        {
            Pen pen = new Pen(Color.Brown);
            Point[] polygon = new Point[Vertex];
            
            for (int i=0; i < Vertex; i++)
            {
                polygon[i].X = Center.X + (int)(Radius * Math.Cos(Math.PI * 2 / Vertex * i + Math.PI / Vertex));
                polygon[i].Y = Center.Y + (int)(Radius * Math.Sin(Math.PI * 2 / Vertex * i + Math.PI / Vertex));
            }
            g.DrawPolygon(pen, polygon);
            p.Invalidate();
        }
    }
}

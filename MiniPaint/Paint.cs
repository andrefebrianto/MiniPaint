using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniPaint
{
    public partial class Paint : Form
    {
        Point start, end;
        Graphics graph;
        Bitmap draw;
        Boolean clicked = false;
        Boolean firstClick = true;

        public Paint()
        {
            InitializeComponent();
            draw = new Bitmap(pbDrawArea.Size.Width,pbDrawArea.Size.Height);
            pbDrawArea.Image = draw;
            txtVertex.Visible = false;
            txtA.Visible = false;
            txtB.Visible = false;
            txtC.Visible = false;
            graph = Graphics.FromImage(draw);
        }

        private void pbDrawArea_MouseUp(object sender, MouseEventArgs e)
        {          
            clicked = false;
            firstClick = false;
        }

        private void pbDrawArea_MouseMove(object sender, MouseEventArgs e)
        {
            end = e.Location;    
            graph.Clear(this.pbDrawArea.BackColor);
            if (rbDDA.Checked && clicked)
            {
                DDA dda = new DDA(start, end);
                dda.DrawLine(graph, pbDrawArea);
            }
            else if (rbLinear.Checked && clicked)
            {
                LinearEquation naive = new LinearEquation(start, end);
                naive.DrawLine(graph, pbDrawArea);
            }
            else if (rbBresenham.Checked && clicked)
            {
                Bresenham bres = new Bresenham(start, end);
                bres.DrawLine(graph, pbDrawArea);
            }
            else if (rbCirlce.Checked && clicked)
            {
                Circle circle = new Circle(start, end);
                circle.DrawCircle(graph, pbDrawArea);
            }
            else if (rbEllipse.Checked && clicked)
            {
                Ellipse elips = new Ellipse(start, end);
                elips.DrawEllipse(graph, pbDrawArea);
            }
            else if (rbPolygon.Checked && clicked && Convert.ToInt32(txtVertex.Text) > 2)
            {
                Polygon poly = new Polygon(start, end, int.Parse(txtVertex.Text));
                poly.DrawPolygon(graph, pbDrawArea);
            }
            else if (rbStar.Checked && clicked && Convert.ToInt32(txtVertex.Text) > 4)
            {
                Star star = new Star(start, end, int.Parse(txtVertex.Text));
                star.DrawStar(graph, pbDrawArea);
            }
        }

        private void rbPolygon_CheckedChanged(object sender, EventArgs e)
        {
            txtVertex.Text = "3";
            txtVertex.Visible = true;
        }

        private void rbStar_CheckedChanged(object sender, EventArgs e)
        {
            txtVertex.Text = "5";
            txtVertex.Visible = true;
        }

        private void btnDraw_Click(object sender, EventArgs e)
        {
            if (rbFunction.Checked && txtA.Text != "" && txtB.Text != "" && txtC.Text != "")
            {
                graph.Clear(this.pbDrawArea.BackColor);
                Function.DrawXaxis(graph, pbDrawArea);
                Function.DrawYaxis(graph, pbDrawArea);
                pbDrawArea.Invalidate();
                Function func = new Function(int.Parse(txtA.Text), int.Parse(txtB.Text), int.Parse(txtC.Text));
                func.DrawFunction(graph, pbDrawArea);
            }
        }

        private void rbFunction_CheckedChanged(object sender, EventArgs e)
        {
            Function.DrawXaxis(graph, pbDrawArea);
            Function.DrawYaxis(graph, pbDrawArea);
            pbDrawArea.Invalidate();
            txtA.Visible = true;
            txtB.Visible = true;
            txtC.Visible = true;
        }

        private void pbDrawArea_MouseDown(object sender, MouseEventArgs e)
        {
            start = e.Location;
            clicked = true;
        }
    }
}

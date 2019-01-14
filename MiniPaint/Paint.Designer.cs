namespace MiniPaint
{
    partial class Paint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.rbCirlce = new System.Windows.Forms.RadioButton();
            this.rbEllipse = new System.Windows.Forms.RadioButton();
            this.pbDrawArea = new System.Windows.Forms.PictureBox();
            this.rbPolygon = new System.Windows.Forms.RadioButton();
            this.txtVertex = new System.Windows.Forms.TextBox();
            this.Vertex = new System.Windows.Forms.Label();
            this.rbStar = new System.Windows.Forms.RadioButton();
            this.rbFunction = new System.Windows.Forms.RadioButton();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.rbLinear = new System.Windows.Forms.RadioButton();
            this.rbBresenham = new System.Windows.Forms.RadioButton();
            this.rbDDA = new System.Windows.Forms.RadioButton();
            this.gbFeatures = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawArea)).BeginInit();
            this.gbFeatures.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbCirlce
            // 
            this.rbCirlce.AutoSize = true;
            this.rbCirlce.Location = new System.Drawing.Point(316, 33);
            this.rbCirlce.Name = "rbCirlce";
            this.rbCirlce.Size = new System.Drawing.Size(51, 17);
            this.rbCirlce.TabIndex = 4;
            this.rbCirlce.TabStop = true;
            this.rbCirlce.Text = "Circle";
            this.rbCirlce.UseVisualStyleBackColor = true;
            // 
            // rbEllipse
            // 
            this.rbEllipse.AutoSize = true;
            this.rbEllipse.Location = new System.Drawing.Point(394, 33);
            this.rbEllipse.Name = "rbEllipse";
            this.rbEllipse.Size = new System.Drawing.Size(55, 17);
            this.rbEllipse.TabIndex = 5;
            this.rbEllipse.TabStop = true;
            this.rbEllipse.Text = "Ellipse";
            this.rbEllipse.UseVisualStyleBackColor = true;
            // 
            // pbDrawArea
            // 
            this.pbDrawArea.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pbDrawArea.Location = new System.Drawing.Point(12, 87);
            this.pbDrawArea.Name = "pbDrawArea";
            this.pbDrawArea.Size = new System.Drawing.Size(980, 403);
            this.pbDrawArea.TabIndex = 6;
            this.pbDrawArea.TabStop = false;
            this.pbDrawArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pbDrawArea_MouseDown);
            this.pbDrawArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pbDrawArea_MouseMove);
            this.pbDrawArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pbDrawArea_MouseUp);
            // 
            // rbPolygon
            // 
            this.rbPolygon.AutoSize = true;
            this.rbPolygon.Location = new System.Drawing.Point(477, 33);
            this.rbPolygon.Name = "rbPolygon";
            this.rbPolygon.Size = new System.Drawing.Size(63, 17);
            this.rbPolygon.TabIndex = 7;
            this.rbPolygon.TabStop = true;
            this.rbPolygon.Text = "Polygon";
            this.rbPolygon.UseVisualStyleBackColor = true;
            this.rbPolygon.CheckedChanged += new System.EventHandler(this.rbPolygon_CheckedChanged);
            // 
            // txtVertex
            // 
            this.txtVertex.Location = new System.Drawing.Point(628, 32);
            this.txtVertex.Name = "txtVertex";
            this.txtVertex.Size = new System.Drawing.Size(55, 20);
            this.txtVertex.TabIndex = 8;
            // 
            // Vertex
            // 
            this.Vertex.AutoSize = true;
            this.Vertex.Location = new System.Drawing.Point(627, 18);
            this.Vertex.Name = "Vertex";
            this.Vertex.Size = new System.Drawing.Size(37, 13);
            this.Vertex.TabIndex = 9;
            this.Vertex.Text = "Vertex";
            // 
            // rbStar
            // 
            this.rbStar.AutoSize = true;
            this.rbStar.Location = new System.Drawing.Point(564, 33);
            this.rbStar.Name = "rbStar";
            this.rbStar.Size = new System.Drawing.Size(44, 17);
            this.rbStar.TabIndex = 10;
            this.rbStar.TabStop = true;
            this.rbStar.Text = "Star";
            this.rbStar.UseVisualStyleBackColor = true;
            this.rbStar.CheckedChanged += new System.EventHandler(this.rbStar_CheckedChanged);
            // 
            // rbFunction
            // 
            this.rbFunction.AutoSize = true;
            this.rbFunction.Location = new System.Drawing.Point(706, 32);
            this.rbFunction.Name = "rbFunction";
            this.rbFunction.Size = new System.Drawing.Size(66, 17);
            this.rbFunction.TabIndex = 11;
            this.rbFunction.TabStop = true;
            this.rbFunction.Text = "Function";
            this.rbFunction.UseVisualStyleBackColor = true;
            this.rbFunction.CheckedChanged += new System.EventHandler(this.rbFunction_CheckedChanged);
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(823, 31);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(32, 20);
            this.txtB.TabIndex = 13;
            // 
            // txtC
            // 
            this.txtC.Location = new System.Drawing.Point(861, 31);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(32, 20);
            this.txtC.TabIndex = 14;
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(785, 31);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(32, 20);
            this.txtA.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(788, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(826, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(864, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "c";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(899, 29);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(75, 23);
            this.btnDraw.TabIndex = 19;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // rbLinear
            // 
            this.rbLinear.AutoSize = true;
            this.rbLinear.Location = new System.Drawing.Point(81, 32);
            this.rbLinear.Name = "rbLinear";
            this.rbLinear.Size = new System.Drawing.Size(99, 17);
            this.rbLinear.TabIndex = 2;
            this.rbLinear.TabStop = true;
            this.rbLinear.Text = "Linear Equation";
            this.rbLinear.UseVisualStyleBackColor = true;
            // 
            // rbBresenham
            // 
            this.rbBresenham.AutoSize = true;
            this.rbBresenham.Location = new System.Drawing.Point(212, 32);
            this.rbBresenham.Name = "rbBresenham";
            this.rbBresenham.Size = new System.Drawing.Size(78, 17);
            this.rbBresenham.TabIndex = 3;
            this.rbBresenham.TabStop = true;
            this.rbBresenham.Text = "Bresenham";
            this.rbBresenham.UseVisualStyleBackColor = true;
            // 
            // rbDDA
            // 
            this.rbDDA.AutoSize = true;
            this.rbDDA.Checked = true;
            this.rbDDA.Location = new System.Drawing.Point(10, 32);
            this.rbDDA.Name = "rbDDA";
            this.rbDDA.Size = new System.Drawing.Size(48, 17);
            this.rbDDA.TabIndex = 1;
            this.rbDDA.TabStop = true;
            this.rbDDA.Text = "DDA";
            this.rbDDA.UseVisualStyleBackColor = true;
            // 
            // gbFeatures
            // 
            this.gbFeatures.BackColor = System.Drawing.Color.SkyBlue;
            this.gbFeatures.Controls.Add(this.btnDraw);
            this.gbFeatures.Controls.Add(this.rbFunction);
            this.gbFeatures.Controls.Add(this.Vertex);
            this.gbFeatures.Controls.Add(this.rbCirlce);
            this.gbFeatures.Controls.Add(this.txtVertex);
            this.gbFeatures.Controls.Add(this.rbLinear);
            this.gbFeatures.Controls.Add(this.txtB);
            this.gbFeatures.Controls.Add(this.rbStar);
            this.gbFeatures.Controls.Add(this.rbDDA);
            this.gbFeatures.Controls.Add(this.label1);
            this.gbFeatures.Controls.Add(this.txtC);
            this.gbFeatures.Controls.Add(this.label2);
            this.gbFeatures.Controls.Add(this.rbEllipse);
            this.gbFeatures.Controls.Add(this.rbPolygon);
            this.gbFeatures.Controls.Add(this.label3);
            this.gbFeatures.Controls.Add(this.txtA);
            this.gbFeatures.Controls.Add(this.rbBresenham);
            this.gbFeatures.Location = new System.Drawing.Point(12, 12);
            this.gbFeatures.Name = "gbFeatures";
            this.gbFeatures.Size = new System.Drawing.Size(980, 69);
            this.gbFeatures.TabIndex = 20;
            this.gbFeatures.TabStop = false;
            this.gbFeatures.Text = "Features";
            // 
            // Paint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1004, 502);
            this.Controls.Add(this.gbFeatures);
            this.Controls.Add(this.pbDrawArea);
            this.Name = "Paint";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbDrawArea)).EndInit();
            this.gbFeatures.ResumeLayout(false);
            this.gbFeatures.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RadioButton rbCirlce;
        private System.Windows.Forms.RadioButton rbEllipse;
        private System.Windows.Forms.PictureBox pbDrawArea;
        private System.Windows.Forms.RadioButton rbPolygon;
        private System.Windows.Forms.Label Vertex;
        private System.Windows.Forms.RadioButton rbStar;
        private System.Windows.Forms.RadioButton rbFunction;
        public System.Windows.Forms.TextBox txtVertex;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.GroupBox gbFeatures;
        private System.Windows.Forms.RadioButton rbDDA;
        private System.Windows.Forms.RadioButton rbBresenham;
        private System.Windows.Forms.RadioButton rbLinear;
    }
}


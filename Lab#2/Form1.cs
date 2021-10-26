using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        ShapeObjectsEditor shapeObjectsEditor = new ShapeObjectsEditor();
        ToolStrip toolStrip = new ToolStrip();
        Graphics g, g2;
        Bitmap pic, pic2;

        public Form1()
        {
            InitializeComponent();
            pic = new Bitmap(Width, Height);
            g = Graphics.FromImage(pic);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            toolStrip.Dot(shapeObjectsEditor);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            toolStrip.Line(shapeObjectsEditor);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            toolStrip.Rectangle(shapeObjectsEditor);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            toolStrip.Ellipse(shapeObjectsEditor);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.BackgroundImage = null;
            pic = new Bitmap(Width, Height);
            g = Graphics.FromImage(pic);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            shapeObjectsEditor.InitPen(Color.Black, Color.Orange, DashStyle.Dash);
            shapeObjectsEditor.OnMouseDown(e);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            shapeObjectsEditor.InitPen(Color.Black, Color.Orange, DashStyle.Solid);
            shapeObjectsEditor.OnMouseUp(e, g);
            pictureBox1.Image = pic;
            shapeObjectsEditor.DisposePen();
            pictureBox1.BackgroundImage = null;
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pic2 = new Bitmap(Width, Height);
                pic2.MakeTransparent();
                g2 = Graphics.FromImage(pic2);
                pictureBox1.BackgroundImage = pic2;
                shapeObjectsEditor.OnMouseMove(e, g2);
            }
        }
    }
}
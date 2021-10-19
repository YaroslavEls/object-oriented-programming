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

        private void dotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = "Drawing Dots";
            shapeObjectsEditor.DotEditor();
        }

        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = "Drawing Lines";
            shapeObjectsEditor.LineEditor();
        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = "Drawing Rectangles";
            shapeObjectsEditor.RectangleEditor();
        }

        private void ellipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text = "Drawing Ellipses";
            shapeObjectsEditor.EllipseEditor();
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


        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*pictureBox1.Image = null;
            pictureBox1.BackgroundImage = null;
            pic = new Bitmap(Width, Height);
            g = Graphics.FromImage(pic);*/
            toolStrip.Create(pictureBox1);
            pic = new Bitmap(Width, Height);
            g = Graphics.FromImage(pic);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            /*pictureBox1.Image = Image.FromFile(@"D:\asd.bmp");
            pic = new Bitmap(pictureBox1.Image);
            g = Graphics.FromImage(pic);*/
            toolStrip.Open(pictureBox1);
            pic = new Bitmap(pictureBox1.Image);
            g = Graphics.FromImage(pic);

        }

        private void Save_Click(object sender, EventArgs e)
        {
            /*pic.Save(@"D:\aaa.bmp");*/
            toolStrip.Save(pic);
        }
    }
}
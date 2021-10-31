using Lab2.objects;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        MyEditor MyEditor = new MyEditor();
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
            toolStrip.Button("Drawing Dots");
            MyEditor.Start(new DotEditor());
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            toolStrip.Button("Drawing Lines");
            MyEditor.Start(new LineEditor());
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            toolStrip.Button("Drawing Rectangles");
            MyEditor.Start(new RectangleEditor());
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            toolStrip.Button("Drawing Ellipses");
            MyEditor.Start(new EllipseEditor());
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
            MyEditor.InitPen(Color.Black, Color.Orange, DashStyle.Dash);
            MyEditor.OnMouseDown(e);
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            toolStrip.Button("Testing");
            MyEditor.Start(new CubeEditor());
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            MyEditor.InitPen(Color.Black, Color.Orange, DashStyle.Solid);
            MyEditor.OnMouseUp(e, g);
            pictureBox1.Image = pic;
            MyEditor.DisposePen();
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
                MyEditor.OnMouseMove(e, g2);
            }
        }
    }
}
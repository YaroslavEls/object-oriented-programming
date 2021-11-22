using Lab2.objects;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        ToolStrip toolStrip = new ToolStrip();
        MyTable TableForm = new MyTable();
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
            toolStrip.Button("Drawing Dot");
            MyEditor.Instance.Start(new DotEditor());
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            toolStrip.Button("Drawing Line");
            MyEditor.Instance.Start(new LineEditor());
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            toolStrip.Button("Drawing Rectangle");
            MyEditor.Instance.Start(new RectangleEditor());
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            toolStrip.Button("Drawing Ellipse");
            MyEditor.Instance.Start(new EllipseEditor());
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            toolStrip.Button("Drawing Cube");
            MyEditor.Instance.Start(new CubeEditor());
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            toolStrip.Button("Drawing Rod");
            MyEditor.Instance.Start(new RodEditor());
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            pictureBox1.BackgroundImage = null;
            pic = new Bitmap(Width, Height);
            g = Graphics.FromImage(pic);

            File.WriteAllText("ObjectsData.txt", String.Empty);
            TableForm.ShowData();
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            if (!TableForm.Visible)
            {
                toolStripLabel2.Text = "Close Table";
                TableForm.StartPosition = FormStartPosition.Manual;
                TableForm.Show();
            } else
            {
                toolStripLabel2.Text = "Open Table";
                TableForm.Hide();
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            MyEditor.Instance.InitPen(Color.Black, Color.Orange, DashStyle.Dash);
            MyEditor.Instance.OnMouseDown(e);
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            MyEditor.Instance.InitPen(Color.Black, Color.Orange, DashStyle.Solid);
            MyEditor.Instance.OnMouseUp(e, g);
            pictureBox1.Image = pic;
            MyEditor.Instance.DisposePen();
            pictureBox1.BackgroundImage = null;

            TableForm.AddData(this.Text.Remove(0, 8), MyEditor.Instance.GetCoords());
            TableForm.ShowData();
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                pic2 = new Bitmap(Width, Height);
                pic2.MakeTransparent();
                g2 = Graphics.FromImage(pic2);
                pictureBox1.BackgroundImage = pic2;
                MyEditor.Instance.OnMouseMove(e, g2);
            }
        }
    }
}
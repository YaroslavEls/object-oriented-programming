using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Object3
{
    public partial class Object3 : Form
    {
        public int x1, y1, x2, y2;
        public Pen pen = new Pen(Color.Black, 1);
        public SolidBrush brush = new SolidBrush(Color.Red);
        public Font font = new Font("Arial", (float)4);

        public Object3()
        {
            InitializeComponent();

            Task.Delay(500).Wait();
            Invalidate();
        }

        private void Object3_Paint(object sender, PaintEventArgs e)
        {
            drawAxes(e);

            string clip = Clipboard.GetText();
            string[] data = clip.Trim().Split(" ");

            for (int i = 0; i < data.Length; i++)
            {
                if ((data.Length - i) > 1)
                {
                    x1 = i;
                    y1 = (int)Double.Parse(data[i]);
                    x2 = i + 1;
                    y2 = (int)Double.Parse(data[i + 1]);
                    e.Graphics.FillEllipse(brush, 10 + (x2 * 20 - 3), ClientSize.Height - (y2 * 10 + 3), 6, 6);
                    e.Graphics.DrawLine(pen, 10 + (x1 * 20), ClientSize.Height - (y1 * 10), 10 + (x2 * 20), ClientSize.Height - (y2 * 10));
                }
            } 
        }

        private void drawAxes(PaintEventArgs e)
        {
            e.Graphics.DrawLine(pen, 10, ClientSize.Height - 10, 10, 0);
            e.Graphics.DrawLine(pen, 10, ClientSize.Height - 10, ClientSize.Width, ClientSize.Height - 10);

            for (int i = 0; i < (ClientSize.Height / 10); i++)
            {
                e.Graphics.DrawString(i.ToString(), font, brush, 10, ClientSize.Height - 10 - (10 * i));
            }

            for (int i = 0; i < (ClientSize.Width / 10); i++)
            {
                e.Graphics.DrawString(i.ToString(), font, brush, 10 + (i * 20), ClientSize.Height - 10);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}

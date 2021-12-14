using System;
using System.Windows.Forms;

namespace RGR
{
    public partial class ConnectForm : Form
    {
        public string Output { get; set; }

        public ConnectForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Output = textBox1.Text;
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

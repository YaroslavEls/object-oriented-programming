using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Module1 : Form
    {
        public string OutputText { get; set; }
        public Module1()
        {
            InitializeComponent();
        }

        private void Module1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OutputText = textBox1.Text;
            Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

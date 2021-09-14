using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Module2 : Form
    {
        public string OutputText { get; set; }

        public Module2()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OutputText = (string)listBox1.SelectedItem;
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

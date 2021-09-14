using System;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Module1 module1Dialog = new Module1();
        Module2 module2Dialog = new Module2();

        public Form1()
        {
            InitializeComponent();
            AddOwnedForm(module1Dialog);
            AddOwnedForm(module2Dialog);
        }

        private void работа1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            module1Dialog.StartPosition = FormStartPosition.CenterParent;
            module1Dialog.ShowDialog();
            Output.Text = module1Dialog.OutputText;
        }

        private void работа2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            module2Dialog.StartPosition = FormStartPosition.CenterParent;
            module2Dialog.ShowDialog();
            Output.Text = module2Dialog.OutputText;
        }
    }
}

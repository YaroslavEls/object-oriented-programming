using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace RGR
{
    public partial class AddForm : Form
    {
        public string Output { get; set; }
        private List<string> items;

        public AddForm(List<string> list)
        {
            InitializeComponent();
            this.items = list;
            Render();
        }

        private void Render()
        {
            items.ForEach(delegate (string name)
            {
                layout.RowStyles.Add(new RowStyle());

                Label label = new Label
                {
                    Name = $"label{name}",
                    Text = name,
                };
                layout.Controls.Add(label, 0, items.IndexOf(name));

                TextBox textBox = new TextBox
                {
                    Name = $"textBox{name}",
                };
                layout.Controls.Add(textBox, 1, items.IndexOf(name));
            });
        }

        private void SetOutput()
        {
            List<string> controls = new List<string>();
            items.ForEach(delegate (string name)
            {
                var control = "'" + layout.Controls.Find($"textBox{name}", false)[0].Text + "'";
                controls.Add(control);
            });

            Output = $"INSERT INTO {Text.Split()[Text.Split().Length - 1]} ({string.Join(", ", items)}) VALUES ({string.Join(", ", controls)})";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SetOutput();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
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

        private void button1_Click(object sender, EventArgs e)
        {
            SetOutput();
            Hide();
        }

        private void Render()
        {
            items.ForEach(delegate (string name)
            {
                Label label = new Label
                {
                    Name = $"label{name}",
                    Text = name,
                    Width = 100,
                    Location = new Point(0, items.IndexOf(name) * 20)
                };
                Controls.Add(label);

                TextBox textBox = new TextBox
                {
                    Name = $"textBox{name}",
                    Width = 100,
                    Location = new Point(120, items.IndexOf(name) * 20)
                };
                Controls.Add(textBox);
            });
        }

        private void SetOutput()
        {
            List<string> controls = new List<string>();
            items.ForEach(delegate (string name)
            {
                var control = "'" + Controls.Find($"textBox{name}", false)[0].Text + "'";
                controls.Add(control);
            });

            Output = $"INSERT INTO {Text.Split()[Text.Split().Length - 1]} ({string.Join(", ", items)}) VALUES ({string.Join(", ", controls)})";
        }
    }
}

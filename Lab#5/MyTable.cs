using System;
using System.IO;
using System.Windows.Forms;

namespace Lab2
{
    public partial class MyTable : Form
    {
        public MyTable()
        {
            InitializeComponent();
            File.WriteAllText("ObjectsData.txt", String.Empty);
        }

        public void AddData(string name, int[] arr)
        {
            if (arr[0] != 0)
            {
                File.AppendAllText("ObjectsData.txt", $"{name} {arr[0]} {arr[1]} {arr[2]} {arr[3]}\n");
            }
        }

        public void ShowData()
        {
            dataGridView1.Rows.Clear();
            foreach (var line in File.ReadLines("ObjectsData.txt"))
            {
                var array = line.Split();
                dataGridView1.Rows.Add(array);
            }
        }

        private void MyTable_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }
    }
}

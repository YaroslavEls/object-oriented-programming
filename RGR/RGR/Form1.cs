using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace RGR
{
    public partial class Form1 : Form
    {
        SqlConnection MyConnection;

        public Form1()
        {
            InitializeComponent();

            Connect();
            LoadTables();
        }

        private void Connect()
        {
            string connectString =
                "Data Source=.\\SQLEXPRESS;" +
                "Initial Catalog=rgr;" +
                "Integrated Security=true;";

            MyConnection = new SqlConnection(connectString);
            MyConnection.Open();
        }

        private void LoadTables()
        {
            string query = "SELECT TABLE_NAME FROM rgr.INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";
            SqlCommand command = new SqlCommand(query, MyConnection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                tablesToolStripMenuItem.DropDownItems.Add(reader.GetValue(0).ToString());
            }

            reader.Close();
        }

        private void LoadColumns(string name)
        {
            string query = $"SELECT COLUMN_NAME FROM rgr.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{name}'";
            SqlCommand command = new SqlCommand(query, MyConnection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                var column = new DataGridViewTextBoxColumn();
                column.HeaderText = reader[0].ToString();
                column.Name = reader[0].ToString();
                dataGridView1.Columns.Add(column);
            }

            reader.Close();
        }

        private void LoadRows(string name)
        {
            string query = $"SELECT * FROM {name}";
            SqlCommand command = new SqlCommand(query, MyConnection);
            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();
            int num = dataGridView1.ColumnCount;

            while (reader.Read())
            {
                data.Add(new string[num]);

                for (int i = 0; i < num; i++)
                {
                    data[data.Count - 1][i] = reader[i].ToString();
                }
            }

            reader.Close();

            foreach (string[] str in data)
            {
                dataGridView1.Rows.Add(str);
            }
        }

        private void tablesToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            LoadColumns(e.ClickedItem.Text);
            LoadRows(e.ClickedItem.Text);

            toolStripStatusLabel2.Text = $"table: {e.ClickedItem.Text}";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MyConnection.Close();
        }

        private void testingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}

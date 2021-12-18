using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace RGR
{
    public partial class MainForm : Form
    {
        SqlConnection MyConnection;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Connect(string name)
        {
            string connectString =
                "Data Source=.\\SQLEXPRESS;" +
                $"Initial Catalog={name};" +
                "Integrated Security=true;";

            MyConnection = new SqlConnection(connectString);
            try
            {
                MyConnection.Open();
                LoadTables();
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTables()
        {
            tablesItem.DropDownItems.Clear();
            tablesItem.Enabled = true;
            string query = "SELECT TABLE_NAME FROM rgr.INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE = 'BASE TABLE'";
            SqlCommand command = new SqlCommand(query, MyConnection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                tablesItem.DropDownItems.Add(reader.GetValue(0).ToString());
            }

            reader.Close();
        }

        private void RenderColumns(string name)
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

        private void RenderRows(string name)
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
                int newRow = dataGridView1.Rows.Add(str);
                dataGridView1.Rows[newRow].HeaderCell.Value = $"{++newRow}";
            }
        }

        private void AddRow()
        {
            List<string> columns = new List<string>();
            foreach (DataGridViewColumn col in dataGridView1.Columns)
            {
                columns.Add(col.HeaderText);
            }

            AddForm AddForm = new AddForm(columns);
            AddForm.Text = tableStatus.Text;
            AddForm.ShowDialog();

            if (AddForm.Output != null)
            {
                SqlCommand command = new SqlCommand(AddForm.Output, MyConnection);

                try
                {
                    command.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            AddForm.Close();
            RefreshTable();
        }

        private void DeleteRow()
        {
            System.Text.StringBuilder values = new System.Text.StringBuilder();

            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                if (i != 0) values.Append(" AND ");
                values.Append(dataGridView1.Columns[i].Name);
                values.Append(" = ");
                values.Append($"'{dataGridView1[i, dataGridView1.CurrentRow.Index].Value.ToString().Trim()}'");
            }

            string request = $"DELETE FROM {tableStatus.Text.Remove(0, 7)} WHERE {values};";

            var confirm = MessageBox.Show("Are you want to delete selected row?", "Are you sure?", MessageBoxButtons.YesNoCancel);

            if (confirm == DialogResult.Yes)
            {
                SqlCommand command = new SqlCommand(request, MyConnection);
                command.ExecuteNonQuery();
            }

            RefreshTable();
        }

        private void ExportTable()
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";
            saveFileDialog1.ShowDialog();
            string dir = saveFileDialog1.FileName;

            if (dir.Length == 0) return;

            using (TextWriter tw = new StreamWriter(dir))
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        tw.Write(($"{dataGridView1[j, i].Value.ToString().Trim()}\t"));
                    }
                    tw.WriteLine();
                }
            }
        }

        private void RefreshTable()
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            string name = tableStatus.Text.Remove(0, 7);
            RenderColumns(name);
            RenderRows(name);
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            tablesItem.Enabled = false;
            addItem.Enabled = false;
            deleteItem.Enabled = false;
            exportItem.Enabled = false;

            ConnectForm ConnectForm = new ConnectForm();
            ConnectForm.ShowDialog();

            string name = ConnectForm.Output;
            ConnectForm.Close();

            Connect(name);
        }

        private void tablesToolStripMenuItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();

            RenderColumns(e.ClickedItem.Text);
            RenderRows(e.ClickedItem.Text);

            tableStatus.Text = $"table: {e.ClickedItem.Text}";
            addItem.Enabled = true;
            deleteItem.Enabled = true;
            exportItem.Enabled = true;
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRow();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteRow();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExportTable();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MyConnection != null)
            {
                MyConnection.Close();
            }
        }

        private void testingToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
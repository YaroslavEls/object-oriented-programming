
namespace Lab2
{
    partial class MyTable
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.column1,
            this.column2,
            this.column3,
            this.column4,
            this.column5});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(627, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // column1
            // 
            this.column1.HeaderText = "Name";
            this.column1.MinimumWidth = 6;
            this.column1.Name = "column1";
            this.column1.ReadOnly = true;
            this.column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.column1.Width = 125;
            // 
            // column2
            // 
            this.column2.HeaderText = "x1";
            this.column2.MinimumWidth = 6;
            this.column2.Name = "column2";
            this.column2.ReadOnly = true;
            this.column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.column2.Width = 75;
            // 
            // column3
            // 
            this.column3.HeaderText = "y1";
            this.column3.MinimumWidth = 6;
            this.column3.Name = "column3";
            this.column3.ReadOnly = true;
            this.column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.column3.Width = 75;
            // 
            // column4
            // 
            this.column4.HeaderText = "x2";
            this.column4.MinimumWidth = 6;
            this.column4.Name = "column4";
            this.column4.ReadOnly = true;
            this.column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.column4.Width = 75;
            // 
            // column5
            // 
            this.column5.HeaderText = "y2";
            this.column5.MinimumWidth = 6;
            this.column5.Name = "column5";
            this.column5.ReadOnly = true;
            this.column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.column5.Width = 75;
            // 
            // MyTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 450);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(900, 100);
            this.Name = "MyTable";
            this.Text = "Shapes table";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MyTable_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn column5;
    }
}
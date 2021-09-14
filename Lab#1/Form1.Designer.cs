
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.Output = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.работаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работа1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.работа2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Output
            // 
            this.Output.AutoSize = true;
            this.Output.Location = new System.Drawing.Point(27, 54);
            this.Output.Name = "Output";
            this.Output.Size = new System.Drawing.Size(0, 20);
            this.Output.TabIndex = 1;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(491, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // работаToolStripMenuItem
            // 
            this.работаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.работа1ToolStripMenuItem,
            this.работа2ToolStripMenuItem});
            this.работаToolStripMenuItem.Name = "работаToolStripMenuItem";
            this.работаToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.работаToolStripMenuItem.Text = "Работа";
            // 
            // работа1ToolStripMenuItem
            // 
            this.работа1ToolStripMenuItem.Name = "работа1ToolStripMenuItem";
            this.работа1ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.работа1ToolStripMenuItem.Text = "Работа 1";
            this.работа1ToolStripMenuItem.Click += new System.EventHandler(this.работа1ToolStripMenuItem_Click);
            // 
            // работа2ToolStripMenuItem
            // 
            this.работа2ToolStripMenuItem.Name = "работа2ToolStripMenuItem";
            this.работа2ToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.работа2ToolStripMenuItem.Text = "Работа 2";
            this.работа2ToolStripMenuItem.Click += new System.EventHandler(this.работа2ToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 367);
            this.Controls.Add(this.Output);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label Output;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem работаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работа1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem работа2ToolStripMenuItem;
    }
}


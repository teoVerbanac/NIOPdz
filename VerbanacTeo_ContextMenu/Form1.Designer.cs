namespace VerbanacTeo_ContextMenu
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lijevoNaDesnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.desnoNaLijevoCtrlLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oProgramuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lijevoNaDesnoToolStripMenuItem,
            this.desnoNaLijevoCtrlLToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(201, 48);
            // 
            // lijevoNaDesnoToolStripMenuItem
            // 
            this.lijevoNaDesnoToolStripMenuItem.Name = "lijevoNaDesnoToolStripMenuItem";
            this.lijevoNaDesnoToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.lijevoNaDesnoToolStripMenuItem.Text = "Lijevo na desno   Ctrl+D";
            this.lijevoNaDesnoToolStripMenuItem.Click += new System.EventHandler(this.lijevoNaDesnoToolStripMenuItem_Click);
            // 
            // desnoNaLijevoCtrlLToolStripMenuItem
            // 
            this.desnoNaLijevoCtrlLToolStripMenuItem.Name = "desnoNaLijevoCtrlLToolStripMenuItem";
            this.desnoNaLijevoCtrlLToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.desnoNaLijevoCtrlLToolStripMenuItem.Text = "Desno na lijevo    Ctrl+L";
            this.desnoNaLijevoCtrlLToolStripMenuItem.Click += new System.EventHandler(this.desnoNaLijevoCtrlLToolStripMenuItem_Click);
            // 
            // txt1
            // 
            this.txt1.ContextMenuStrip = this.contextMenuStrip1;
            this.txt1.Location = new System.Drawing.Point(99, 117);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(112, 20);
            this.txt1.TabIndex = 1;
            // 
            // txt2
            // 
            this.txt2.ContextMenuStrip = this.contextMenuStrip1;
            this.txt2.Location = new System.Drawing.Point(290, 117);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(113, 20);
            this.txt2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::VerbanacTeo_ContextMenu.Properties.Resources.cc_licence4;
            this.pictureBox1.Location = new System.Drawing.Point(463, 318);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(563, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oProgramuToolStripMenuItem
            // 
            this.oProgramuToolStripMenuItem.Name = "oProgramuToolStripMenuItem";
            this.oProgramuToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.oProgramuToolStripMenuItem.Text = "O programu";
            this.oProgramuToolStripMenuItem.Click += new System.EventHandler(this.oProgramuToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 361);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lijevoNaDesnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem desnoNaLijevoCtrlLToolStripMenuItem;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oProgramuToolStripMenuItem;
    }
}


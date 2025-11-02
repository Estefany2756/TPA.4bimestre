namespace TPA.exercicios_estefany.otavio_
{
    partial class frmmenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiprogramas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmitabuada1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmitabuada2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmitabuada3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmisair = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmigraus1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmigraus2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmigraus3 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiarea1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiarea2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiarea3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiprogramas,
            this.tsmisair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiprogramas
            // 
            this.tsmiprogramas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmitabuada1,
            this.tsmitabuada2,
            this.tsmitabuada3,
            this.tsmigraus1,
            this.tsmigraus2,
            this.tsmigraus3,
            this.tsmiarea1,
            this.tsmiarea2,
            this.tsmiarea3});
            this.tsmiprogramas.Name = "tsmiprogramas";
            this.tsmiprogramas.Size = new System.Drawing.Size(94, 24);
            this.tsmiprogramas.Text = "Programas";
            // 
            // tsmitabuada1
            // 
            this.tsmitabuada1.Name = "tsmitabuada1";
            this.tsmitabuada1.Size = new System.Drawing.Size(224, 26);
            this.tsmitabuada1.Text = "Tabuada 1";
            this.tsmitabuada1.Click += new System.EventHandler(this.tsmitabuada1_Click);
            // 
            // tsmitabuada2
            // 
            this.tsmitabuada2.Name = "tsmitabuada2";
            this.tsmitabuada2.Size = new System.Drawing.Size(224, 26);
            this.tsmitabuada2.Text = "Tabuada 2";
            this.tsmitabuada2.Click += new System.EventHandler(this.tsmitabuada2_Click);
            // 
            // tsmitabuada3
            // 
            this.tsmitabuada3.Name = "tsmitabuada3";
            this.tsmitabuada3.Size = new System.Drawing.Size(224, 26);
            this.tsmitabuada3.Text = "Tabuada 3";
            this.tsmitabuada3.Click += new System.EventHandler(this.tsmitabuada3_Click);
            // 
            // tsmisair
            // 
            this.tsmisair.Name = "tsmisair";
            this.tsmisair.Size = new System.Drawing.Size(48, 24);
            this.tsmisair.Text = "Sair";
            this.tsmisair.Click += new System.EventHandler(this.tsmisair_Click);
            // 
            // tsmigraus1
            // 
            this.tsmigraus1.Name = "tsmigraus1";
            this.tsmigraus1.Size = new System.Drawing.Size(224, 26);
            this.tsmigraus1.Text = "Graus 1";
            this.tsmigraus1.Click += new System.EventHandler(this.tsmigraus1_Click);
            // 
            // tsmigraus2
            // 
            this.tsmigraus2.Name = "tsmigraus2";
            this.tsmigraus2.Size = new System.Drawing.Size(224, 26);
            this.tsmigraus2.Text = "Graus 2";
            this.tsmigraus2.Click += new System.EventHandler(this.tsmigraus2_Click);
            // 
            // tsmigraus3
            // 
            this.tsmigraus3.Name = "tsmigraus3";
            this.tsmigraus3.Size = new System.Drawing.Size(224, 26);
            this.tsmigraus3.Text = "Graus 3";
            this.tsmigraus3.Click += new System.EventHandler(this.tsmigraus3_Click);
            // 
            // tsmiarea1
            // 
            this.tsmiarea1.Name = "tsmiarea1";
            this.tsmiarea1.Size = new System.Drawing.Size(224, 26);
            this.tsmiarea1.Text = "Área 1 (incompleto)";
            this.tsmiarea1.Click += new System.EventHandler(this.tsmiarea1_Click);
            // 
            // tsmiarea2
            // 
            this.tsmiarea2.Name = "tsmiarea2";
            this.tsmiarea2.Size = new System.Drawing.Size(224, 26);
            this.tsmiarea2.Text = "Área 2";
            // 
            // tsmiarea3
            // 
            this.tsmiarea3.Name = "tsmiarea3";
            this.tsmiarea3.Size = new System.Drawing.Size(224, 26);
            this.tsmiarea3.Text = "Área 3";
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiprogramas;
        private System.Windows.Forms.ToolStripMenuItem tsmitabuada1;
        private System.Windows.Forms.ToolStripMenuItem tsmitabuada2;
        private System.Windows.Forms.ToolStripMenuItem tsmitabuada3;
        private System.Windows.Forms.ToolStripMenuItem tsmisair;
        private System.Windows.Forms.ToolStripMenuItem tsmigraus1;
        private System.Windows.Forms.ToolStripMenuItem tsmigraus2;
        private System.Windows.Forms.ToolStripMenuItem tsmigraus3;
        private System.Windows.Forms.ToolStripMenuItem tsmiarea1;
        private System.Windows.Forms.ToolStripMenuItem tsmiarea2;
        private System.Windows.Forms.ToolStripMenuItem tsmiarea3;
    }
}
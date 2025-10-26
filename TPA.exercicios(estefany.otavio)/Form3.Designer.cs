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
            this.tsmisair = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmitabuada1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmitabuada2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmitabuada3 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.tsmitabuada3});
            this.tsmiprogramas.Name = "tsmiprogramas";
            this.tsmiprogramas.Size = new System.Drawing.Size(94, 24);
            this.tsmiprogramas.Text = "Programas";
            // 
            // tsmisair
            // 
            this.tsmisair.Name = "tsmisair";
            this.tsmisair.Size = new System.Drawing.Size(48, 24);
            this.tsmisair.Text = "Sair";
            this.tsmisair.Click += new System.EventHandler(this.tsmisair_Click);
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
            // 
            // frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmmenu";
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
    }
}
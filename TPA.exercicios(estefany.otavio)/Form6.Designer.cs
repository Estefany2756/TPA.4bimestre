namespace TPA.exercicios_estefany.otavio_
{
    partial class frmgraus2
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
            this.lblgraus = new System.Windows.Forms.Label();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnconverter = new System.Windows.Forms.Button();
            this.txtgraus = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblgraus
            // 
            this.lblgraus.AutoSize = true;
            this.lblgraus.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgraus.Location = new System.Drawing.Point(100, 72);
            this.lblgraus.Name = "lblgraus";
            this.lblgraus.Size = new System.Drawing.Size(539, 26);
            this.lblgraus.TabIndex = 9;
            this.lblgraus.Text = "A conversão de graus para fahreinheit (10 em 10) é:";
            this.lblgraus.Click += new System.EventHandler(this.lblgraus_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.Pink;
            this.btnvoltar.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(126, 377);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(143, 41);
            this.btnvoltar.TabIndex = 8;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.BackColor = System.Drawing.Color.Pink;
            this.btnlimpar.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlimpar.Location = new System.Drawing.Point(126, 263);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(143, 41);
            this.btnlimpar.TabIndex = 7;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = false;
            this.btnlimpar.Click += new System.EventHandler(this.btnlimpar_Click);
            // 
            // btnconverter
            // 
            this.btnconverter.BackColor = System.Drawing.Color.Pink;
            this.btnconverter.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnconverter.Location = new System.Drawing.Point(126, 157);
            this.btnconverter.Name = "btnconverter";
            this.btnconverter.Size = new System.Drawing.Size(143, 41);
            this.btnconverter.TabIndex = 6;
            this.btnconverter.Text = "Converter";
            this.btnconverter.UseVisualStyleBackColor = false;
            this.btnconverter.Click += new System.EventHandler(this.btnconverter_Click);
            // 
            // txtgraus
            // 
            this.txtgraus.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgraus.Location = new System.Drawing.Point(375, 161);
            this.txtgraus.Multiline = true;
            this.txtgraus.Name = "txtgraus";
            this.txtgraus.ReadOnly = true;
            this.txtgraus.Size = new System.Drawing.Size(144, 270);
            this.txtgraus.TabIndex = 5;
            this.txtgraus.TextChanged += new System.EventHandler(this.txtgraus_TextChanged);
            // 
            // frmgraus2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 502);
            this.Controls.Add(this.lblgraus);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btnconverter);
            this.Controls.Add(this.txtgraus);
            this.Name = "frmgraus2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Conversão (faca)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblgraus;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnconverter;
        private System.Windows.Forms.TextBox txtgraus;
    }
}
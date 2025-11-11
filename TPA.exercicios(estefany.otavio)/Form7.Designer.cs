namespace TPA.exercicios_estefany.otavio_
{
    partial class frmarea1
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
            this.lblcmd = new System.Windows.Forms.Label();
            this.lbllarg = new System.Windows.Forms.Label();
            this.lblcomp = new System.Windows.Forms.Label();
            this.lblarea = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.txtlarg = new System.Windows.Forms.TextBox();
            this.txtcomp = new System.Windows.Forms.TextBox();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcmd
            // 
            this.lblcmd.AutoSize = true;
            this.lblcmd.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcmd.Location = new System.Drawing.Point(86, 48);
            this.lblcmd.Name = "lblcmd";
            this.lblcmd.Size = new System.Drawing.Size(0, 26);
            this.lblcmd.TabIndex = 0;
            // 
            // lbllarg
            // 
            this.lbllarg.AutoSize = true;
            this.lbllarg.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbllarg.Location = new System.Drawing.Point(66, 64);
            this.lbllarg.Name = "lbllarg";
            this.lbllarg.Size = new System.Drawing.Size(308, 26);
            this.lbllarg.TabIndex = 1;
            this.lbllarg.Text = "Informe a largura do cômodo:";
            // 
            // lblcomp
            // 
            this.lblcomp.AutoSize = true;
            this.lblcomp.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomp.Location = new System.Drawing.Point(66, 118);
            this.lblcomp.Name = "lblcomp";
            this.lblcomp.Size = new System.Drawing.Size(374, 26);
            this.lblcomp.TabIndex = 2;
            this.lblcomp.Text = "Informe o comprimento do cômodo :";
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblarea.Location = new System.Drawing.Point(66, 184);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(240, 26);
            this.lblarea.TabIndex = 3;
            this.lblarea.Text = "A área do cômodo   é: ";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotal.Location = new System.Drawing.Point(66, 246);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(337, 26);
            this.lbltotal.TabIndex = 4;
            this.lbltotal.Text = "A área total de sua residência é:";
            // 
            // txtlarg
            // 
            this.txtlarg.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlarg.Location = new System.Drawing.Point(498, 64);
            this.txtlarg.Name = "txtlarg";
            this.txtlarg.Size = new System.Drawing.Size(119, 34);
            this.txtlarg.TabIndex = 7;
            // 
            // txtcomp
            // 
            this.txtcomp.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcomp.Location = new System.Drawing.Point(498, 115);
            this.txtcomp.Name = "txtcomp";
            this.txtcomp.Size = new System.Drawing.Size(119, 34);
            this.txtcomp.TabIndex = 9;
            // 
            // txtarea
            // 
            this.txtarea.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtarea.Location = new System.Drawing.Point(498, 181);
            this.txtarea.Name = "txtarea";
            this.txtarea.ReadOnly = true;
            this.txtarea.Size = new System.Drawing.Size(119, 34);
            this.txtarea.TabIndex = 11;
            // 
            // txttotal
            // 
            this.txttotal.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttotal.Location = new System.Drawing.Point(494, 243);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(123, 34);
            this.txttotal.TabIndex = 12;
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.Pink;
            this.btncalcular.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncalcular.Location = new System.Drawing.Point(169, 360);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(123, 43);
            this.btncalcular.TabIndex = 13;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.Color.Pink;
            this.btnvoltar.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(392, 360);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(119, 43);
            this.btnvoltar.TabIndex = 15;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnvoltar_Click);
            // 
            // frmarea1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 471);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.txtcomp);
            this.Controls.Add(this.txtlarg);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.lblcomp);
            this.Controls.Add(this.lbllarg);
            this.Controls.Add(this.lblcmd);
            this.Name = "frmarea1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de Área (if else)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcmd;
        private System.Windows.Forms.Label lbllarg;
        private System.Windows.Forms.Label lblcomp;
        private System.Windows.Forms.Label lblarea;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txtlarg;
        private System.Windows.Forms.TextBox txtcomp;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnvoltar;
    }
}
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
            this.txtcmd = new System.Windows.Forms.TextBox();
            this.txtcmdI = new System.Windows.Forms.TextBox();
            this.txtlarg = new System.Windows.Forms.TextBox();
            this.txtcmdII = new System.Windows.Forms.TextBox();
            this.txtcomp = new System.Windows.Forms.TextBox();
            this.txtcmdIII = new System.Windows.Forms.TextBox();
            this.txtarea = new System.Windows.Forms.TextBox();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.btncalcular = new System.Windows.Forms.Button();
            this.btnlimpar = new System.Windows.Forms.Button();
            this.btnvoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcmd
            // 
            this.lblcmd.AutoSize = true;
            this.lblcmd.Location = new System.Drawing.Point(86, 48);
            this.lblcmd.Name = "lblcmd";
            this.lblcmd.Size = new System.Drawing.Size(255, 16);
            this.lblcmd.TabIndex = 0;
            this.lblcmd.Text = "Quantos cômodos há em sua residência?";
            // 
            // lbllarg
            // 
            this.lbllarg.AutoSize = true;
            this.lbllarg.Location = new System.Drawing.Point(86, 113);
            this.lbllarg.Name = "lbllarg";
            this.lbllarg.Size = new System.Drawing.Size(233, 16);
            this.lbllarg.TabIndex = 1;
            this.lbllarg.Text = "Informe a largura do cômodo                 :";
            // 
            // lblcomp
            // 
            this.lblcomp.AutoSize = true;
            this.lblcomp.Location = new System.Drawing.Point(86, 173);
            this.lblcomp.Name = "lblcomp";
            this.lblcomp.Size = new System.Drawing.Size(269, 16);
            this.lblcomp.TabIndex = 2;
            this.lblcomp.Text = "Informe o comprimento do cômodo                 :";
            // 
            // lblarea
            // 
            this.lblarea.AutoSize = true;
            this.lblarea.Location = new System.Drawing.Point(86, 236);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(163, 16);
            this.lblarea.TabIndex = 3;
            this.lblarea.Text = "A área do cômodo          é: ";
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.Location = new System.Drawing.Point(90, 292);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(199, 16);
            this.lbltotal.TabIndex = 4;
            this.lbltotal.Text = "A área total de sua residência é:";
            // 
            // txtcmd
            // 
            this.txtcmd.Location = new System.Drawing.Point(366, 47);
            this.txtcmd.Name = "txtcmd";
            this.txtcmd.Size = new System.Drawing.Size(100, 22);
            this.txtcmd.TabIndex = 5;
            // 
            // txtcmdI
            // 
            this.txtcmdI.Location = new System.Drawing.Point(277, 113);
            this.txtcmdI.Name = "txtcmdI";
            this.txtcmdI.Size = new System.Drawing.Size(22, 22);
            this.txtcmdI.TabIndex = 6;
            // 
            // txtlarg
            // 
            this.txtlarg.Location = new System.Drawing.Point(336, 111);
            this.txtlarg.Name = "txtlarg";
            this.txtlarg.Size = new System.Drawing.Size(100, 22);
            this.txtlarg.TabIndex = 7;
            // 
            // txtcmdII
            // 
            this.txtcmdII.Location = new System.Drawing.Point(318, 170);
            this.txtcmdII.Name = "txtcmdII";
            this.txtcmdII.Size = new System.Drawing.Size(23, 22);
            this.txtcmdII.TabIndex = 8;
            // 
            // txtcomp
            // 
            this.txtcomp.Location = new System.Drawing.Point(361, 170);
            this.txtcomp.Name = "txtcomp";
            this.txtcomp.Size = new System.Drawing.Size(100, 22);
            this.txtcomp.TabIndex = 9;
            // 
            // txtcmdIII
            // 
            this.txtcmdIII.Location = new System.Drawing.Point(204, 233);
            this.txtcmdIII.Name = "txtcmdIII";
            this.txtcmdIII.Size = new System.Drawing.Size(23, 22);
            this.txtcmdIII.TabIndex = 10;
            // 
            // txtarea
            // 
            this.txtarea.Location = new System.Drawing.Point(255, 233);
            this.txtarea.Name = "txtarea";
            this.txtarea.Size = new System.Drawing.Size(100, 22);
            this.txtarea.TabIndex = 11;
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(302, 292);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 22);
            this.txttotal.TabIndex = 12;
            // 
            // btncalcular
            // 
            this.btncalcular.Location = new System.Drawing.Point(102, 375);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(75, 23);
            this.btncalcular.TabIndex = 13;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = true;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click);
            // 
            // btnlimpar
            // 
            this.btnlimpar.Location = new System.Drawing.Point(224, 375);
            this.btnlimpar.Name = "btnlimpar";
            this.btnlimpar.Size = new System.Drawing.Size(75, 23);
            this.btnlimpar.TabIndex = 14;
            this.btnlimpar.Text = "Limpar";
            this.btnlimpar.UseVisualStyleBackColor = true;
            // 
            // btnvoltar
            // 
            this.btnvoltar.Location = new System.Drawing.Point(361, 375);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(75, 23);
            this.btnvoltar.TabIndex = 15;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = true;
            // 
            // frmarea1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(this.btnlimpar);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.txtarea);
            this.Controls.Add(this.txtcmdIII);
            this.Controls.Add(this.txtcomp);
            this.Controls.Add(this.txtcmdII);
            this.Controls.Add(this.txtlarg);
            this.Controls.Add(this.txtcmdI);
            this.Controls.Add(this.txtcmd);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lblarea);
            this.Controls.Add(this.lblcomp);
            this.Controls.Add(this.lbllarg);
            this.Controls.Add(this.lblcmd);
            this.Name = "frmarea1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculo de Área (enquanto)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcmd;
        private System.Windows.Forms.Label lbllarg;
        private System.Windows.Forms.Label lblcomp;
        private System.Windows.Forms.Label lblarea;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.TextBox txtcmd;
        private System.Windows.Forms.TextBox txtcmdI;
        private System.Windows.Forms.TextBox txtlarg;
        private System.Windows.Forms.TextBox txtcmdII;
        private System.Windows.Forms.TextBox txtcomp;
        private System.Windows.Forms.TextBox txtcmdIII;
        private System.Windows.Forms.TextBox txtarea;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.Button btnlimpar;
        private System.Windows.Forms.Button btnvoltar;
    }
}
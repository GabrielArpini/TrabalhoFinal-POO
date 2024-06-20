namespace ControleFinanceiro
{
    partial class LogarForms
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogarForms));
            this.ImgLogoLogar = new System.Windows.Forms.PictureBox();
            this.lblUserLogar = new System.Windows.Forms.Label();
            this.txtBoxUserLogar = new System.Windows.Forms.TextBox();
            this.txtBoxPassLogar = new System.Windows.Forms.TextBox();
            this.lblSenhaLogar = new System.Windows.Forms.Label();
            this.btnLoginLogar = new System.Windows.Forms.Button();
            this.btnRegisterLogar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogoLogar)).BeginInit();
            this.SuspendLayout();
            // 
            // ImgLogoLogar
            // 
            this.ImgLogoLogar.Image = ((System.Drawing.Image)(resources.GetObject("ImgLogoLogar.Image")));
            this.ImgLogoLogar.Location = new System.Drawing.Point(282, 41);
            this.ImgLogoLogar.Name = "ImgLogoLogar";
            this.ImgLogoLogar.Size = new System.Drawing.Size(244, 174);
            this.ImgLogoLogar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgLogoLogar.TabIndex = 0;
            this.ImgLogoLogar.TabStop = false;
            this.ImgLogoLogar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblUserLogar
            // 
            this.lblUserLogar.AutoSize = true;
            this.lblUserLogar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUserLogar.Location = new System.Drawing.Point(303, 230);
            this.lblUserLogar.Name = "lblUserLogar";
            this.lblUserLogar.Size = new System.Drawing.Size(46, 13);
            this.lblUserLogar.TabIndex = 1;
            this.lblUserLogar.Text = "Usuário:";
            this.lblUserLogar.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBoxUserLogar
            // 
            this.txtBoxUserLogar.Location = new System.Drawing.Point(306, 255);
            this.txtBoxUserLogar.Name = "txtBoxUserLogar";
            this.txtBoxUserLogar.Size = new System.Drawing.Size(200, 20);
            this.txtBoxUserLogar.TabIndex = 2;
            // 
            // txtBoxPassLogar
            // 
            this.txtBoxPassLogar.Location = new System.Drawing.Point(306, 321);
            this.txtBoxPassLogar.Name = "txtBoxPassLogar";
            this.txtBoxPassLogar.PasswordChar = '*';
            this.txtBoxPassLogar.Size = new System.Drawing.Size(200, 20);
            this.txtBoxPassLogar.TabIndex = 4;
            this.txtBoxPassLogar.UseSystemPasswordChar = true;
            // 
            // lblSenhaLogar
            // 
            this.lblSenhaLogar.AutoSize = true;
            this.lblSenhaLogar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSenhaLogar.Location = new System.Drawing.Point(303, 296);
            this.lblSenhaLogar.Name = "lblSenhaLogar";
            this.lblSenhaLogar.Size = new System.Drawing.Size(41, 13);
            this.lblSenhaLogar.TabIndex = 3;
            this.lblSenhaLogar.Text = "Senha:";
            // 
            // btnLoginLogar
            // 
            this.btnLoginLogar.Location = new System.Drawing.Point(306, 364);
            this.btnLoginLogar.Name = "btnLoginLogar";
            this.btnLoginLogar.Size = new System.Drawing.Size(75, 23);
            this.btnLoginLogar.TabIndex = 5;
            this.btnLoginLogar.Text = "Entrar";
            this.btnLoginLogar.UseVisualStyleBackColor = true;
            this.btnLoginLogar.Click += new System.EventHandler(this.btnLoginLogar_Click);
            // 
            // btnRegisterLogar
            // 
            this.btnRegisterLogar.Location = new System.Drawing.Point(431, 364);
            this.btnRegisterLogar.Name = "btnRegisterLogar";
            this.btnRegisterLogar.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterLogar.TabIndex = 6;
            this.btnRegisterLogar.Text = "Registrar";
            this.btnRegisterLogar.UseVisualStyleBackColor = true;
            this.btnRegisterLogar.Click += new System.EventHandler(this.btnRegisterLogar_Click);
            // 
            // LogarForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRegisterLogar);
            this.Controls.Add(this.btnLoginLogar);
            this.Controls.Add(this.txtBoxPassLogar);
            this.Controls.Add(this.lblSenhaLogar);
            this.Controls.Add(this.txtBoxUserLogar);
            this.Controls.Add(this.lblUserLogar);
            this.Controls.Add(this.ImgLogoLogar);
            this.Name = "LogarForms";
            this.Text = "Logar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.LogarForms_FormClosed);
            this.Load += new System.EventHandler(this.LogarForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogoLogar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgLogoLogar;
        private System.Windows.Forms.Label lblUserLogar;
        private System.Windows.Forms.TextBox txtBoxUserLogar;
        private System.Windows.Forms.TextBox txtBoxPassLogar;
        private System.Windows.Forms.Label lblSenhaLogar;
        private System.Windows.Forms.Button btnLoginLogar;
        private System.Windows.Forms.Button btnRegisterLogar;
    }
}


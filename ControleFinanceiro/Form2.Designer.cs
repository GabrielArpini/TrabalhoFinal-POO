namespace ControleFinanceiro
{
    partial class RegistrarForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarForms));
            this.btnRegisterRegistrar = new System.Windows.Forms.Button();
            this.txtBoxEmailRegistrar = new System.Windows.Forms.TextBox();
            this.lblEmailRegistrar = new System.Windows.Forms.Label();
            this.txtBoxUserRegistrar = new System.Windows.Forms.TextBox();
            this.lblUserRegistrar = new System.Windows.Forms.Label();
            this.ImgLogoRegistrar = new System.Windows.Forms.PictureBox();
            this.txtBoxPassRegistrar = new System.Windows.Forms.TextBox();
            this.lblPassRegistrar = new System.Windows.Forms.Label();
            this.txtBoxNameRegistrar = new System.Windows.Forms.TextBox();
            this.lblNameRegistrar = new System.Windows.Forms.Label();
            this.dataGridViewRegistrar = new System.Windows.Forms.DataGridView();
            this.btnEntrarRegistrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogoRegistrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrar)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegisterRegistrar
            // 
            this.btnRegisterRegistrar.Location = new System.Drawing.Point(12, 415);
            this.btnRegisterRegistrar.Name = "btnRegisterRegistrar";
            this.btnRegisterRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterRegistrar.TabIndex = 13;
            this.btnRegisterRegistrar.Text = "Registrar";
            this.btnRegisterRegistrar.UseVisualStyleBackColor = true;
            this.btnRegisterRegistrar.Click += new System.EventHandler(this.btnRegisterRegistrar_Click);
            // 
            // txtBoxEmailRegistrar
            // 
            this.txtBoxEmailRegistrar.Location = new System.Drawing.Point(9, 254);
            this.txtBoxEmailRegistrar.Name = "txtBoxEmailRegistrar";
            this.txtBoxEmailRegistrar.Size = new System.Drawing.Size(200, 20);
            this.txtBoxEmailRegistrar.TabIndex = 11;
            // 
            // lblEmailRegistrar
            // 
            this.lblEmailRegistrar.AutoSize = true;
            this.lblEmailRegistrar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmailRegistrar.Location = new System.Drawing.Point(6, 229);
            this.lblEmailRegistrar.Name = "lblEmailRegistrar";
            this.lblEmailRegistrar.Size = new System.Drawing.Size(35, 13);
            this.lblEmailRegistrar.TabIndex = 10;
            this.lblEmailRegistrar.Text = "Email:";
            // 
            // txtBoxUserRegistrar
            // 
            this.txtBoxUserRegistrar.Location = new System.Drawing.Point(9, 197);
            this.txtBoxUserRegistrar.Name = "txtBoxUserRegistrar";
            this.txtBoxUserRegistrar.Size = new System.Drawing.Size(200, 20);
            this.txtBoxUserRegistrar.TabIndex = 9;
            // 
            // lblUserRegistrar
            // 
            this.lblUserRegistrar.AutoSize = true;
            this.lblUserRegistrar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUserRegistrar.Location = new System.Drawing.Point(6, 172);
            this.lblUserRegistrar.Name = "lblUserRegistrar";
            this.lblUserRegistrar.Size = new System.Drawing.Size(46, 13);
            this.lblUserRegistrar.TabIndex = 8;
            this.lblUserRegistrar.Text = "Usuário:";
            // 
            // ImgLogoRegistrar
            // 
            this.ImgLogoRegistrar.Image = ((System.Drawing.Image)(resources.GetObject("ImgLogoRegistrar.Image")));
            this.ImgLogoRegistrar.Location = new System.Drawing.Point(-3, 12);
            this.ImgLogoRegistrar.Name = "ImgLogoRegistrar";
            this.ImgLogoRegistrar.Size = new System.Drawing.Size(231, 157);
            this.ImgLogoRegistrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgLogoRegistrar.TabIndex = 7;
            this.ImgLogoRegistrar.TabStop = false;
            // 
            // txtBoxPassRegistrar
            // 
            this.txtBoxPassRegistrar.Location = new System.Drawing.Point(12, 375);
            this.txtBoxPassRegistrar.Name = "txtBoxPassRegistrar";
            this.txtBoxPassRegistrar.Size = new System.Drawing.Size(200, 20);
            this.txtBoxPassRegistrar.TabIndex = 17;
            // 
            // lblPassRegistrar
            // 
            this.lblPassRegistrar.AutoSize = true;
            this.lblPassRegistrar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblPassRegistrar.Location = new System.Drawing.Point(9, 350);
            this.lblPassRegistrar.Name = "lblPassRegistrar";
            this.lblPassRegistrar.Size = new System.Drawing.Size(41, 13);
            this.lblPassRegistrar.TabIndex = 16;
            this.lblPassRegistrar.Text = "Senha:";
            // 
            // txtBoxNameRegistrar
            // 
            this.txtBoxNameRegistrar.Location = new System.Drawing.Point(12, 314);
            this.txtBoxNameRegistrar.Name = "txtBoxNameRegistrar";
            this.txtBoxNameRegistrar.Size = new System.Drawing.Size(200, 20);
            this.txtBoxNameRegistrar.TabIndex = 15;
            // 
            // lblNameRegistrar
            // 
            this.lblNameRegistrar.AutoSize = true;
            this.lblNameRegistrar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNameRegistrar.Location = new System.Drawing.Point(9, 289);
            this.lblNameRegistrar.Name = "lblNameRegistrar";
            this.lblNameRegistrar.Size = new System.Drawing.Size(84, 13);
            this.lblNameRegistrar.TabIndex = 14;
            this.lblNameRegistrar.Text = "Nome completo:";
            this.lblNameRegistrar.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridViewRegistrar
            // 
            this.dataGridViewRegistrar.AllowUserToOrderColumns = true;
            this.dataGridViewRegistrar.BackgroundColor = System.Drawing.SystemColors.ControlText;
            this.dataGridViewRegistrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRegistrar.Enabled = false;
            this.dataGridViewRegistrar.Location = new System.Drawing.Point(259, 66);
            this.dataGridViewRegistrar.MultiSelect = false;
            this.dataGridViewRegistrar.Name = "dataGridViewRegistrar";
            this.dataGridViewRegistrar.ReadOnly = true;
            this.dataGridViewRegistrar.ShowCellErrors = false;
            this.dataGridViewRegistrar.ShowRowErrors = false;
            this.dataGridViewRegistrar.Size = new System.Drawing.Size(504, 372);
            this.dataGridViewRegistrar.TabIndex = 18;
            this.dataGridViewRegistrar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewRegistrar_CellContentClick_1);
            // 
            // btnEntrarRegistrar
            // 
            this.btnEntrarRegistrar.Location = new System.Drawing.Point(137, 415);
            this.btnEntrarRegistrar.Name = "btnEntrarRegistrar";
            this.btnEntrarRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnEntrarRegistrar.TabIndex = 19;
            this.btnEntrarRegistrar.Text = "Entrar";
            this.btnEntrarRegistrar.UseVisualStyleBackColor = true;
            this.btnEntrarRegistrar.Click += new System.EventHandler(this.btnEntrarRegistrar_Click);
            // 
            // RegistrarForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEntrarRegistrar);
            this.Controls.Add(this.dataGridViewRegistrar);
            this.Controls.Add(this.txtBoxPassRegistrar);
            this.Controls.Add(this.lblPassRegistrar);
            this.Controls.Add(this.txtBoxNameRegistrar);
            this.Controls.Add(this.lblNameRegistrar);
            this.Controls.Add(this.btnRegisterRegistrar);
            this.Controls.Add(this.txtBoxEmailRegistrar);
            this.Controls.Add(this.lblEmailRegistrar);
            this.Controls.Add(this.txtBoxUserRegistrar);
            this.Controls.Add(this.lblUserRegistrar);
            this.Controls.Add(this.ImgLogoRegistrar);
            this.Name = "RegistrarForms";
            this.Text = "Registrar";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrarForms_FormClosed);
            this.Load += new System.EventHandler(this.RegistrarForms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogoRegistrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRegistrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegisterRegistrar;
        private System.Windows.Forms.TextBox txtBoxEmailRegistrar;
        private System.Windows.Forms.Label lblEmailRegistrar;
        private System.Windows.Forms.TextBox txtBoxUserRegistrar;
        private System.Windows.Forms.Label lblUserRegistrar;
        private System.Windows.Forms.PictureBox ImgLogoRegistrar;
        private System.Windows.Forms.TextBox txtBoxPassRegistrar;
        private System.Windows.Forms.Label lblPassRegistrar;
        private System.Windows.Forms.TextBox txtBoxNameRegistrar;
        private System.Windows.Forms.Label lblNameRegistrar;
        private System.Windows.Forms.DataGridView dataGridViewRegistrar;
        private System.Windows.Forms.Button btnEntrarRegistrar;
    }
}
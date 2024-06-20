namespace ControleFinanceiro
{
    partial class FormPopUp
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
            this.lblFixText1Alterar = new System.Windows.Forms.Label();
            this.lbl21 = new System.Windows.Forms.Label();
            this.lbl22 = new System.Windows.Forms.Label();
            this.lbl23 = new System.Windows.Forms.Label();
            this.lbl11 = new System.Windows.Forms.Label();
            this.txtBoxEmailConfig = new System.Windows.Forms.TextBox();
            this.txtBoxNameConfig = new System.Windows.Forms.TextBox();
            this.txtBoxUserConfig = new System.Windows.Forms.TextBox();
            this.txtBoxPassConfig = new System.Windows.Forms.TextBox();
            this.txtBoxConfirmConfig = new System.Windows.Forms.TextBox();
            this.lbl12 = new System.Windows.Forms.Label();
            this.btnChangeConfig = new System.Windows.Forms.Button();
            this.lblUsernameMain = new System.Windows.Forms.Label();
            this.txtBoxNewPassConfig = new System.Windows.Forms.TextBox();
            this.lbl24 = new System.Windows.Forms.Label();
            this.btnConfirmConfig = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFixText1Alterar
            // 
            this.lblFixText1Alterar.AutoSize = true;
            this.lblFixText1Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixText1Alterar.ForeColor = System.Drawing.SystemColors.Control;
            this.lblFixText1Alterar.Location = new System.Drawing.Point(57, 28);
            this.lblFixText1Alterar.Name = "lblFixText1Alterar";
            this.lblFixText1Alterar.Size = new System.Drawing.Size(283, 31);
            this.lblFixText1Alterar.TabIndex = 0;
            this.lblFixText1Alterar.Text = "Informações da conta:";
            // 
            // lbl21
            // 
            this.lbl21.AutoSize = true;
            this.lbl21.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl21.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl21.Location = new System.Drawing.Point(60, 104);
            this.lbl21.Name = "lbl21";
            this.lbl21.Size = new System.Drawing.Size(66, 25);
            this.lbl21.TabIndex = 1;
            this.lbl21.Text = "Email:";
            this.lbl21.Visible = false;
            // 
            // lbl22
            // 
            this.lbl22.AutoSize = true;
            this.lbl22.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl22.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl22.Location = new System.Drawing.Point(60, 195);
            this.lbl22.Name = "lbl22";
            this.lbl22.Size = new System.Drawing.Size(153, 25);
            this.lbl22.TabIndex = 4;
            this.lbl22.Text = "Nome Completo";
            this.lbl22.Visible = false;
            // 
            // lbl23
            // 
            this.lbl23.AutoSize = true;
            this.lbl23.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl23.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl23.Location = new System.Drawing.Point(538, 104);
            this.lbl23.Name = "lbl23";
            this.lbl23.Size = new System.Drawing.Size(85, 25);
            this.lbl23.TabIndex = 5;
            this.lbl23.Text = "Usuário:";
            this.lbl23.Visible = false;
            // 
            // lbl11
            // 
            this.lbl11.AutoSize = true;
            this.lbl11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl11.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl11.Location = new System.Drawing.Point(304, 104);
            this.lbl11.Name = "lbl11";
            this.lbl11.Size = new System.Drawing.Size(76, 25);
            this.lbl11.TabIndex = 6;
            this.lbl11.Text = "Senha:";
            // 
            // txtBoxEmailConfig
            // 
            this.txtBoxEmailConfig.Location = new System.Drawing.Point(65, 146);
            this.txtBoxEmailConfig.Name = "txtBoxEmailConfig";
            this.txtBoxEmailConfig.Size = new System.Drawing.Size(180, 20);
            this.txtBoxEmailConfig.TabIndex = 9;
            this.txtBoxEmailConfig.Visible = false;
            // 
            // txtBoxNameConfig
            // 
            this.txtBoxNameConfig.Location = new System.Drawing.Point(65, 241);
            this.txtBoxNameConfig.Name = "txtBoxNameConfig";
            this.txtBoxNameConfig.Size = new System.Drawing.Size(180, 20);
            this.txtBoxNameConfig.TabIndex = 11;
            this.txtBoxNameConfig.Visible = false;
            // 
            // txtBoxUserConfig
            // 
            this.txtBoxUserConfig.Location = new System.Drawing.Point(543, 146);
            this.txtBoxUserConfig.Name = "txtBoxUserConfig";
            this.txtBoxUserConfig.Size = new System.Drawing.Size(180, 20);
            this.txtBoxUserConfig.TabIndex = 13;
            this.txtBoxUserConfig.Visible = false;
            // 
            // txtBoxPassConfig
            // 
            this.txtBoxPassConfig.Location = new System.Drawing.Point(309, 150);
            this.txtBoxPassConfig.Name = "txtBoxPassConfig";
            this.txtBoxPassConfig.PasswordChar = '*';
            this.txtBoxPassConfig.Size = new System.Drawing.Size(180, 20);
            this.txtBoxPassConfig.TabIndex = 14;
            this.txtBoxPassConfig.UseSystemPasswordChar = true;
            // 
            // txtBoxConfirmConfig
            // 
            this.txtBoxConfirmConfig.Location = new System.Drawing.Point(309, 238);
            this.txtBoxConfirmConfig.Name = "txtBoxConfirmConfig";
            this.txtBoxConfirmConfig.PasswordChar = '*';
            this.txtBoxConfirmConfig.Size = new System.Drawing.Size(180, 20);
            this.txtBoxConfirmConfig.TabIndex = 16;
            this.txtBoxConfirmConfig.UseSystemPasswordChar = true;
            this.txtBoxConfirmConfig.TextChanged += new System.EventHandler(this.txtBoxConfirmConfig_TextChanged);
            // 
            // lbl12
            // 
            this.lbl12.AutoSize = true;
            this.lbl12.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl12.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl12.Location = new System.Drawing.Point(304, 192);
            this.lbl12.Name = "lbl12";
            this.lbl12.Size = new System.Drawing.Size(162, 25);
            this.lbl12.TabIndex = 15;
            this.lbl12.Text = "Confirmar senha:";
            // 
            // btnChangeConfig
            // 
            this.btnChangeConfig.Location = new System.Drawing.Point(341, 374);
            this.btnChangeConfig.Name = "btnChangeConfig";
            this.btnChangeConfig.Size = new System.Drawing.Size(116, 45);
            this.btnChangeConfig.TabIndex = 17;
            this.btnChangeConfig.Text = "Alterar";
            this.btnChangeConfig.UseVisualStyleBackColor = true;
            this.btnChangeConfig.Visible = false;
            this.btnChangeConfig.Click += new System.EventHandler(this.button4_Click);
            // 
            // lblUsernameMain
            // 
            this.lblUsernameMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameMain.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsernameMain.Location = new System.Drawing.Point(575, 9);
            this.lblUsernameMain.Name = "lblUsernameMain";
            this.lblUsernameMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUsernameMain.Size = new System.Drawing.Size(178, 43);
            this.lblUsernameMain.TabIndex = 40;
            this.lblUsernameMain.Text = "USERNAME";
            // 
            // txtBoxNewPassConfig
            // 
            this.txtBoxNewPassConfig.Location = new System.Drawing.Point(543, 241);
            this.txtBoxNewPassConfig.Name = "txtBoxNewPassConfig";
            this.txtBoxNewPassConfig.Size = new System.Drawing.Size(180, 20);
            this.txtBoxNewPassConfig.TabIndex = 42;
            this.txtBoxNewPassConfig.Visible = false;
            // 
            // lbl24
            // 
            this.lbl24.AutoSize = true;
            this.lbl24.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl24.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl24.Location = new System.Drawing.Point(538, 195);
            this.lbl24.Name = "lbl24";
            this.lbl24.Size = new System.Drawing.Size(76, 25);
            this.lbl24.TabIndex = 41;
            this.lbl24.Text = "Senha:";
            this.lbl24.Visible = false;
            // 
            // btnConfirmConfig
            // 
            this.btnConfirmConfig.Enabled = false;
            this.btnConfirmConfig.Location = new System.Drawing.Point(341, 285);
            this.btnConfirmConfig.Name = "btnConfirmConfig";
            this.btnConfirmConfig.Size = new System.Drawing.Size(116, 45);
            this.btnConfirmConfig.TabIndex = 43;
            this.btnConfirmConfig.Text = "Confirmar";
            this.btnConfirmConfig.UseVisualStyleBackColor = true;
            this.btnConfirmConfig.Click += new System.EventHandler(this.btnConfirmConfig_Click);
            // 
            // FormPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnConfirmConfig);
            this.Controls.Add(this.txtBoxNewPassConfig);
            this.Controls.Add(this.lbl24);
            this.Controls.Add(this.lblUsernameMain);
            this.Controls.Add(this.btnChangeConfig);
            this.Controls.Add(this.txtBoxConfirmConfig);
            this.Controls.Add(this.lbl12);
            this.Controls.Add(this.txtBoxPassConfig);
            this.Controls.Add(this.txtBoxUserConfig);
            this.Controls.Add(this.txtBoxNameConfig);
            this.Controls.Add(this.txtBoxEmailConfig);
            this.Controls.Add(this.lbl11);
            this.Controls.Add(this.lbl23);
            this.Controls.Add(this.lbl22);
            this.Controls.Add(this.lbl21);
            this.Controls.Add(this.lblFixText1Alterar);
            this.Name = "FormPopUp";
            this.Text = "Alterar dados";
            this.Load += new System.EventHandler(this.FormPopUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFixText1Alterar;
        private System.Windows.Forms.Label lbl21;
        private System.Windows.Forms.Label lbl22;
        private System.Windows.Forms.Label lbl23;
        private System.Windows.Forms.Label lbl11;
        private System.Windows.Forms.TextBox txtBoxEmailConfig;
        private System.Windows.Forms.TextBox txtBoxNameConfig;
        private System.Windows.Forms.TextBox txtBoxUserConfig;
        private System.Windows.Forms.TextBox txtBoxPassConfig;
        private System.Windows.Forms.TextBox txtBoxConfirmConfig;
        private System.Windows.Forms.Label lbl12;
        private System.Windows.Forms.Button btnChangeConfig;
        private System.Windows.Forms.Label lblUsernameMain;
        private System.Windows.Forms.TextBox txtBoxNewPassConfig;
        private System.Windows.Forms.Label lbl24;
        private System.Windows.Forms.Button btnConfirmConfig;
    }
}
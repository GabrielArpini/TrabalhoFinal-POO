namespace ControleFinanceiro
{
    partial class FormConfig
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConfig));
            this.button1 = new System.Windows.Forms.Button();
            this.btn3Main = new System.Windows.Forms.Button();
            this.btn1Main = new System.Windows.Forms.Button();
            this.ImgLogo1Main = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblUsernameMain = new System.Windows.Forms.Label();
            this.btnAlterarDadosConfig = new System.Windows.Forms.Button();
            this.btnDeleteAccConfig = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo1Main)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 38);
            this.button1.TabIndex = 30;
            this.button1.Text = "Configurações";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn3Main
            // 
            this.btn3Main.Location = new System.Drawing.Point(12, 257);
            this.btn3Main.Name = "btn3Main";
            this.btn3Main.Size = new System.Drawing.Size(200, 38);
            this.btn3Main.TabIndex = 29;
            this.btn3Main.Text = "Gerenciar";
            this.btn3Main.UseVisualStyleBackColor = true;
            this.btn3Main.Click += new System.EventHandler(this.btn3Main_Click);
            // 
            // btn1Main
            // 
            this.btn1Main.Location = new System.Drawing.Point(12, 199);
            this.btn1Main.Name = "btn1Main";
            this.btn1Main.Size = new System.Drawing.Size(200, 38);
            this.btn1Main.TabIndex = 27;
            this.btn1Main.Text = "Menu";
            this.btn1Main.UseVisualStyleBackColor = true;
            this.btn1Main.Click += new System.EventHandler(this.btn1Main_Click);
            // 
            // ImgLogo1Main
            // 
            this.ImgLogo1Main.Image = ((System.Drawing.Image)(resources.GetObject("ImgLogo1Main.Image")));
            this.ImgLogo1Main.Location = new System.Drawing.Point(-1, 38);
            this.ImgLogo1Main.Name = "ImgLogo1Main";
            this.ImgLogo1Main.Size = new System.Drawing.Size(241, 155);
            this.ImgLogo1Main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgLogo1Main.TabIndex = 26;
            this.ImgLogo1Main.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(243, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 31);
            this.label2.TabIndex = 32;
            this.label2.Text = "Configurações:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(244, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 33;
            this.label3.Text = "Geral:";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(440, 187);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(146, 50);
            this.button2.TabIndex = 34;
            this.button2.Text = "Sair";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(440, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 58);
            this.button3.TabIndex = 36;
            this.button3.Text = "Excluir todos os dados";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(244, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Excluir dados:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(246, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 37;
            this.label5.Text = "Opções gerais:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(246, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(431, 49);
            this.label6.TabIndex = 38;
            this.label6.Text = "Excluir todos os arquivos xml gerados pelo programa no diretório criado (C:\\POOGr" +
    "upo11Xml) ou apenas excluir os dados desta conta: ";
            // 
            // lblUsernameMain
            // 
            this.lblUsernameMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameMain.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsernameMain.Location = new System.Drawing.Point(575, 9);
            this.lblUsernameMain.Name = "lblUsernameMain";
            this.lblUsernameMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUsernameMain.Size = new System.Drawing.Size(178, 43);
            this.lblUsernameMain.TabIndex = 39;
            this.lblUsernameMain.Text = "USERNAME";
            // 
            // btnAlterarDadosConfig
            // 
            this.btnAlterarDadosConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarDadosConfig.Location = new System.Drawing.Point(249, 187);
            this.btnAlterarDadosConfig.Name = "btnAlterarDadosConfig";
            this.btnAlterarDadosConfig.Size = new System.Drawing.Size(146, 50);
            this.btnAlterarDadosConfig.TabIndex = 40;
            this.btnAlterarDadosConfig.Text = "Alterar dados";
            this.btnAlterarDadosConfig.UseVisualStyleBackColor = true;
            this.btnAlterarDadosConfig.Click += new System.EventHandler(this.btnAlterarDadosConfig_Click);
            // 
            // btnDeleteAccConfig
            // 
            this.btnDeleteAccConfig.BackColor = System.Drawing.Color.Red;
            this.btnDeleteAccConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAccConfig.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteAccConfig.Location = new System.Drawing.Point(249, 369);
            this.btnDeleteAccConfig.Name = "btnDeleteAccConfig";
            this.btnDeleteAccConfig.Size = new System.Drawing.Size(146, 58);
            this.btnDeleteAccConfig.TabIndex = 41;
            this.btnDeleteAccConfig.Text = "Excluir conta";
            this.btnDeleteAccConfig.UseVisualStyleBackColor = false;
            // 
            // FormConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDeleteAccConfig);
            this.Controls.Add(this.btnAlterarDadosConfig);
            this.Controls.Add(this.lblUsernameMain);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn3Main);
            this.Controls.Add(this.btn1Main);
            this.Controls.Add(this.ImgLogo1Main);
            this.Name = "FormConfig";
            this.Text = "Configurações";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormConfig_FormClosed);
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo1Main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn3Main;
        private System.Windows.Forms.Button btn1Main;
        private System.Windows.Forms.PictureBox ImgLogo1Main;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblUsernameMain;
        private System.Windows.Forms.Button btnAlterarDadosConfig;
        private System.Windows.Forms.Button btnDeleteAccConfig;
    }
}
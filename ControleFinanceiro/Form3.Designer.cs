namespace ControleFinanceiro
{
    partial class MainMenuForms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForms));
            this.ImgLogo1Main = new System.Windows.Forms.PictureBox();
            this.btn1Main = new System.Windows.Forms.Button();
            this.btn3Main = new System.Windows.Forms.Button();
            this.lblUsernameMain = new System.Windows.Forms.Label();
            this.panel1App = new System.Windows.Forms.Panel();
            this.lblGanhosApp = new System.Windows.Forms.Label();
            this.lblFix1App = new System.Windows.Forms.Label();
            this.panel2App = new System.Windows.Forms.Panel();
            this.lblGastosApp = new System.Windows.Forms.Label();
            this.lblFix2App = new System.Windows.Forms.Label();
            this.panel3App = new System.Windows.Forms.Panel();
            this.lblSaldoApp = new System.Windows.Forms.Label();
            this.lblFix3App = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo1Main)).BeginInit();
            this.panel1App.SuspendLayout();
            this.panel2App.SuspendLayout();
            this.panel3App.SuspendLayout();
            this.SuspendLayout();
            // 
            // ImgLogo1Main
            // 
            this.ImgLogo1Main.Image = ((System.Drawing.Image)(resources.GetObject("ImgLogo1Main.Image")));
            this.ImgLogo1Main.Location = new System.Drawing.Point(-6, 24);
            this.ImgLogo1Main.Name = "ImgLogo1Main";
            this.ImgLogo1Main.Size = new System.Drawing.Size(240, 162);
            this.ImgLogo1Main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImgLogo1Main.TabIndex = 8;
            this.ImgLogo1Main.TabStop = false;
            this.ImgLogo1Main.Click += new System.EventHandler(this.ImgLogoApp_Click);
            // 
            // btn1Main
            // 
            this.btn1Main.Location = new System.Drawing.Point(12, 200);
            this.btn1Main.Name = "btn1Main";
            this.btn1Main.Size = new System.Drawing.Size(200, 38);
            this.btn1Main.TabIndex = 9;
            this.btn1Main.Text = "Menu";
            this.btn1Main.UseVisualStyleBackColor = true;
            this.btn1Main.MouseCaptureChanged += new System.EventHandler(this.button1_MouseCaptureChanged);
            // 
            // btn3Main
            // 
            this.btn3Main.Location = new System.Drawing.Point(12, 257);
            this.btn3Main.Name = "btn3Main";
            this.btn3Main.Size = new System.Drawing.Size(200, 38);
            this.btn3Main.TabIndex = 11;
            this.btn3Main.Text = "Gerenciar";
            this.btn3Main.UseVisualStyleBackColor = true;
            this.btn3Main.Click += new System.EventHandler(this.btn3Main_Click);
            // 
            // lblUsernameMain
            // 
            this.lblUsernameMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameMain.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUsernameMain.Location = new System.Drawing.Point(575, 9);
            this.lblUsernameMain.Name = "lblUsernameMain";
            this.lblUsernameMain.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblUsernameMain.Size = new System.Drawing.Size(178, 43);
            this.lblUsernameMain.TabIndex = 12;
            this.lblUsernameMain.Text = "USERNAME";
            // 
            // panel1App
            // 
            this.panel1App.BackColor = System.Drawing.Color.SeaGreen;
            this.panel1App.Controls.Add(this.lblGanhosApp);
            this.panel1App.Controls.Add(this.lblFix1App);
            this.panel1App.Location = new System.Drawing.Point(245, 55);
            this.panel1App.Name = "panel1App";
            this.panel1App.Size = new System.Drawing.Size(264, 140);
            this.panel1App.TabIndex = 13;
            // 
            // lblGanhosApp
            // 
            this.lblGanhosApp.AutoSize = true;
            this.lblGanhosApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGanhosApp.Location = new System.Drawing.Point(109, 56);
            this.lblGanhosApp.Name = "lblGanhosApp";
            this.lblGanhosApp.Size = new System.Drawing.Size(36, 39);
            this.lblGanhosApp.TabIndex = 1;
            this.lblGanhosApp.Text = "0";
            this.lblGanhosApp.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblFix1App
            // 
            this.lblFix1App.AutoSize = true;
            this.lblFix1App.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFix1App.Location = new System.Drawing.Point(16, 15);
            this.lblFix1App.Name = "lblFix1App";
            this.lblFix1App.Size = new System.Drawing.Size(87, 25);
            this.lblFix1App.TabIndex = 0;
            this.lblFix1App.Text = "Ganhos:";
            // 
            // panel2App
            // 
            this.panel2App.BackColor = System.Drawing.Color.DarkRed;
            this.panel2App.Controls.Add(this.lblGastosApp);
            this.panel2App.Controls.Add(this.lblFix2App);
            this.panel2App.ForeColor = System.Drawing.SystemColors.Control;
            this.panel2App.Location = new System.Drawing.Point(245, 214);
            this.panel2App.Name = "panel2App";
            this.panel2App.Size = new System.Drawing.Size(264, 140);
            this.panel2App.TabIndex = 14;
            // 
            // lblGastosApp
            // 
            this.lblGastosApp.AutoSize = true;
            this.lblGastosApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGastosApp.Location = new System.Drawing.Point(109, 63);
            this.lblGastosApp.Name = "lblGastosApp";
            this.lblGastosApp.Size = new System.Drawing.Size(36, 39);
            this.lblGastosApp.TabIndex = 1;
            this.lblGastosApp.Text = "0";
            this.lblGastosApp.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblFix2App
            // 
            this.lblFix2App.AutoSize = true;
            this.lblFix2App.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFix2App.Location = new System.Drawing.Point(16, 15);
            this.lblFix2App.Name = "lblFix2App";
            this.lblFix2App.Size = new System.Drawing.Size(80, 25);
            this.lblFix2App.TabIndex = 0;
            this.lblFix2App.Text = "Gastos:";
            // 
            // panel3App
            // 
            this.panel3App.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel3App.Controls.Add(this.lblSaldoApp);
            this.panel3App.Controls.Add(this.lblFix3App);
            this.panel3App.Location = new System.Drawing.Point(523, 159);
            this.panel3App.Name = "panel3App";
            this.panel3App.Size = new System.Drawing.Size(226, 95);
            this.panel3App.TabIndex = 14;
            // 
            // lblSaldoApp
            // 
            this.lblSaldoApp.AutoSize = true;
            this.lblSaldoApp.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldoApp.Location = new System.Drawing.Point(88, 39);
            this.lblSaldoApp.Name = "lblSaldoApp";
            this.lblSaldoApp.Size = new System.Drawing.Size(36, 39);
            this.lblSaldoApp.TabIndex = 2;
            this.lblSaldoApp.Text = "0";
            // 
            // lblFix3App
            // 
            this.lblFix3App.AutoSize = true;
            this.lblFix3App.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFix3App.Location = new System.Drawing.Point(10, 8);
            this.lblFix3App.Name = "lblFix3App";
            this.lblFix3App.Size = new System.Drawing.Size(69, 25);
            this.lblFix3App.TabIndex = 0;
            this.lblFix3App.Text = "Saldo:";
            this.lblFix3App.Click += new System.EventHandler(this.label7_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 317);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 38);
            this.button1.TabIndex = 25;
            this.button1.Text = "Configurações";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainMenuForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel3App);
            this.Controls.Add(this.panel2App);
            this.Controls.Add(this.panel1App);
            this.Controls.Add(this.lblUsernameMain);
            this.Controls.Add(this.btn3Main);
            this.Controls.Add(this.btn1Main);
            this.Controls.Add(this.ImgLogo1Main);
            this.Name = "MainMenuForms";
            this.Text = "MainMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.dashboardForm_FormClosed);
            this.Load += new System.EventHandler(this.dashboardForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ImgLogo1Main)).EndInit();
            this.panel1App.ResumeLayout(false);
            this.panel1App.PerformLayout();
            this.panel2App.ResumeLayout(false);
            this.panel2App.PerformLayout();
            this.panel3App.ResumeLayout(false);
            this.panel3App.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ImgLogo1Main;
        private System.Windows.Forms.Button btn1Main;
        private System.Windows.Forms.Button btn3Main;
        private System.Windows.Forms.Label lblUsernameMain;
        private System.Windows.Forms.Panel panel1App;
        private System.Windows.Forms.Label lblGanhosApp;
        private System.Windows.Forms.Label lblFix1App;
        private System.Windows.Forms.Panel panel2App;
        private System.Windows.Forms.Label lblGastosApp;
        private System.Windows.Forms.Label lblFix2App;
        private System.Windows.Forms.Panel panel3App;
        private System.Windows.Forms.Label lblFix3App;
        private System.Windows.Forms.Label lblSaldoApp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}
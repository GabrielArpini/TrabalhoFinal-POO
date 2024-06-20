using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace ControleFinanceiro
{
    public partial class FormConfig : Form
    {
        public FormConfig(string user)
        {
            InitializeComponent();
            lblUsernameMain.Text = user;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Tem certeza que gostaria de excluir?",
                                     "Confirmar Exclusão!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                var folder = new DirectoryInfo(@"C:\\POOGrupo11Xml");
                folder.Delete(true);
                Application.Exit();
            }

        }

        private void FormConfig_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn1Main_Click(object sender, EventArgs e)
        {
            MainMenuForms mainMenuForms = new MainMenuForms(this.lblUsernameMain.Text);
            this.Hide();
            mainMenuForms.Show();
        }

        private void btn3Main_Click(object sender, EventArgs e)
        {
            gerenciarForms gerenciarForms = new gerenciarForms(this.lblUsernameMain.Text);
            this.Hide();
            gerenciarForms.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LogarForms logarForms = new LogarForms();
            this.Hide();
            logarForms.Show();
        }

        private void btnAlterarDadosConfig_Click(object sender, EventArgs e)
        {
            FormPopUp formPopUp = new FormPopUp(lblUsernameMain.Text);
            formPopUp.Show();
        }
    }
}

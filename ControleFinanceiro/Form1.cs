using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace ControleFinanceiro
{
    public partial class LogarForms : Form
    {
        public LogarForms()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnRegisterLogar_Click(object sender, EventArgs e)
        {
            RegistrarForms registrarForms = new RegistrarForms();
            this.Hide();
            registrarForms.ShowDialog();

        }

        private void LogarForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnLoginLogar_Click(object sender, EventArgs e)
        {
            Usuarios usuarios = new Usuarios();
            usuarios.Carregar();
            var db = usuarios.ListarTodos();
            bool isLogin = false;
            string user = "";
            foreach(var u in db)
            {
                if(u.Username == txtBoxUserLogar.Text && u.Password == txtBoxPassLogar.Text)
                {
                    user = u.Username;
                    isLogin = true;
                }
            }
            if (isLogin)
            {

                MainMenuForms dashboardForm = new MainMenuForms(txtBoxUserLogar.Text);
                this.Hide();
                dashboardForm.ShowDialog();

            }
            else
            {
                MessageBox.Show("Usuario ou senha incorretos");
            }
            


        }

        private void LogarForms_Load(object sender, EventArgs e)
        {

        }
    }
}

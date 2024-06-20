using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 

namespace ControleFinanceiro
{
    public partial class RegistrarForms : Form
    {
        private Usuarios usuarios; 
        public RegistrarForms()
        {
            InitializeComponent();
        }

        private void RegistrarForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarForms_Load(object sender, EventArgs e)
        {
            usuarios = new Usuarios();
            usuarios.Carregar();
            dataGridViewRegistrar.DataSource = usuarios.ListarTodos();
        }

        private void btnRegisterRegistrar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario()
            {
                Name = txtBoxNameRegistrar.Text,
                Email = txtBoxEmailRegistrar.Text,
                Username = txtBoxUserRegistrar.Text,
                Password = txtBoxPassRegistrar.Text,
            };
            try
            {
                if(user.Name.Length > 0 && user.Email.Length > 0 && user.Username.Length > 0 && user.Password.Length > 0)
                {
                    if(user.Password.Length > 6) 
                    {
                        usuarios.Adicionar(user);
                        usuarios.Salvar();
                        dataGridViewRegistrar.DataSource = null;
                        dataGridViewRegistrar.DataSource = usuarios.ListarTodos();
                    }
                    else 
                    {
                        MessageBox.Show("A senha deve ser maior do que 6 caractéres");
                    }
                        
                }
                else
                {
                    MessageBox.Show("Os campos devem estar preenchidos");
                }
            
            }
            catch(System.Exception)
            {
                MessageBox.Show("Já existe um usuario com o usuario fornecido");
            }


        }

        private void dataGridViewRegistrar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEntrarRegistrar_Click(object sender, EventArgs e)
        {
            LogarForms logarForms = new LogarForms();
            this.Hide();
            logarForms.Show();
        }

        private void dataGridViewRegistrar_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

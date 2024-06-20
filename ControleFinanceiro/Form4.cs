using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace ControleFinanceiro
{
    public partial class FormPopUp : Form
    {
        private Usuarios usuarios;
        private int index;
        private List<Usuario> list;
        public FormPopUp(string username)
        {
            InitializeComponent();
            lblUsernameMain.Text = username;
            
        }

        private void FormPopUp_Load(object sender, EventArgs e)
        {
            usuarios = new Usuarios();
            usuarios.Carregar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            List<Usuario> users = usuarios.ListarTodos();
            Usuario u = users[index];
            u.Email = txtBoxEmailConfig.Text;
            u.Password = txtBoxNewPassConfig.Text;
            u.Name = txtBoxNameConfig.Text;
            usuarios.Atualizar(users);
            usuarios.Salvar();
            MessageBox.Show("Dados alterados com sucesso!");
            this.Close();
            
        }

        private void txtBoxConfirmConfig_TextChanged(object sender, EventArgs e)
        {
            if(txtBoxPassConfig.Text.Length > 0)
            {
                btnConfirmConfig.Enabled = true;
            }
        }

        private void btnConfirmConfig_Click(object sender, EventArgs e)
        {

            list = usuarios.ListarTodos();
            bool isAuth = false;
            index = 0;
            for(int i = 0; i < list.Count;i++)
            {
                if (list[i].Password == txtBoxConfirmConfig.Text && list[i].Password == txtBoxPassConfig.Text)
                {
                    isAuth = true;index = i; break;
                    
                }
            }
            //foreach(Usuario u in list)
            //{
                //if((u.Password ==  txtBoxConfirmConfig.Text) && (u.Password == txtBoxPassConfig.Text))
                //{

                   // isAuth = true; break;
                //}
                
            //}
            if (isAuth)
            {
                lbl11.Visible = false;
                lbl12.Visible = false;
                txtBoxPassConfig.Visible = false;
                txtBoxConfirmConfig.Visible = false;
                btnConfirmConfig.Visible = false;

                lbl21.Visible = true;
                lbl22.Visible=true;
                lbl23.Visible=true;
                lbl24.Visible=true;
                txtBoxEmailConfig.Visible = true;
                txtBoxNameConfig.Visible = true;
                txtBoxUserConfig.Visible = true;
                txtBoxNewPassConfig.Visible = true;
                btnChangeConfig.Visible = true;
                
                txtBoxEmailConfig.Text = list[index].Email;
                txtBoxNameConfig.Text = list[index].Name;
                txtBoxUserConfig.Text = list[index].Username;
                txtBoxUserConfig.Enabled = false;
                txtBoxNewPassConfig.Text = list[index].Password;
                
            }
            else
            {
                MessageBox.Show("A senha está incorreta ou os campos não são iguais");
            }
        }
    }
}
